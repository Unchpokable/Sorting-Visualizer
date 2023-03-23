using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sorting.Implementation;

namespace Sorting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AllowTransparency = true;
            //FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            _dataSizeSelector.SelectedIndexChanged += CheckSelectedDataSize;
            _algorithmSelector.SelectedIndexChanged += CheckSelectedDataSize;
            _drawFieldGraphics = _drawField.CreateGraphics();

            _algorithms = new VisualisableSortingAlgorithm[]
            {
                new BubbleSortAlgorithm(_drawFieldGraphics),
                new QSortAlgorithm(_drawFieldGraphics),
                new SortTreeAlgorithm(_drawFieldGraphics),
                new InsertionSortAlgorithm(_drawFieldGraphics),
                new MergeSortAlgorithm(_drawFieldGraphics),
                //new RedBlackTreeSortAlgorithm(_drawFieldGraphics)
            };

            InitSizes();
            _algorithmSelector.DataSource = _algorithms;
            _warningLabel.Text = "";
            _warningHugeDataSelected.Text = "";
            _drawField.CreateGraphics().FillRectangle(new SolidBrush(Color.Black), 0, 0, _drawField.Width, _drawField.Height);
            _itemColorViewColor = Color.LightBlue;
            _bgColorViewColor = Color.Black;
            _backgroundColorView.BackColor = _bgColorViewColor;
            _itemColorView.BackColor = _itemColorViewColor;
            _useDelayCheckbox.Checked = true;
            _renderingDelayView.Text = _renderingDelayTrackbar.Value.ToString();
            _renderingDelay = _renderingDelayTrackbar.Value;
        }

        private List<DataSize<int>> _sizes;
        private VisualisableSortingAlgorithm[] _algorithms;
        private Graphics _drawFieldGraphics;
        private bool _shouldWarnUser = false;
        private Color _bgColorViewColor;
        private Color _itemColorViewColor;
        private Thread _activeSortingThread;
        private int _renderingDelay;

        private void CheckSelectedDataSize(object sender, EventArgs e)
        {
            _warningHugeDataSelected.Text = "";
            _warningLabel.Text = "";
            _shouldWarnUser = false;

            if (((DataSize<int>)_dataSizeSelector?.SelectedItem)?.TotalDataSetSize > 512
                && _useDelayCheckbox.Checked)
            {
                _warningLabel.Text = "Warning: Using delay function with big data sets\n may cause insanely slow sorting";
                _shouldWarnUser = true;
            }
            if (((DataSize<int>)_dataSizeSelector?.SelectedItem)?.TotalDataSetSize / 1024 > 4)
            {
                _warningHugeDataSelected.Text = "Warning: Selected huge data size (>4 KiB). \nSorting can take much more time";
                _shouldWarnUser = true;
            }
        }

        private void ResizeWindow(int newWidth)
        {
            Size = new Size(newWidth, Size.Height);
        }

        private void ExecuteSorting(object sender, EventArgs e)
        {
            if (_shouldWarnUser)
            {
             var result = MessageBox.Show("You selected huge data set or too slow algorithm for selected data set. Sorting will take a lot of time. Are you sure to continue?",
                    "Last warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                    ExecuteSotringInternal();
                return;
            }
            ExecuteSotringInternal();
        }

        private void ExecuteSotringInternal()
        {
            var random = new Random();
            var sorter = (VisualisableSortingAlgorithm)_algorithmSelector.SelectedItem;
            var dataSet = (DataSize<int>)_dataSizeSelector.SelectedItem;
            var pixelPerValue = _drawField.Width / dataSet.ItemsCount;
            pixelPerValue = pixelPerValue > 0 ? pixelPerValue : 1;

            if (pixelPerValue == 0)
                MessageBox.Show("Selected data size may cause problems with rendering (too few pixels per array element)");
            MessageBox.Show($"With this data size there will be {pixelPerValue} pixels per value on drawing desk");

            sorter.PixelsPerUnit = pixelPerValue;
            sorter.DrawTimeout = _useDelayCheckbox.Checked ? _renderingDelay : 0;
            sorter.MaxHeight = _drawField.Height;
            sorter.BackgroundColor = _bgColorViewColor;
            sorter.ItemColor = _itemColorViewColor;

            //resize window cause somethimes colored bars doesn't fill all graphics field and it looks not so cool
            if (pixelPerValue == 1)
            {
                ResizeWindow(Size.Width + (dataSet.ItemsCount * pixelPerValue - _drawField.Width));
                _drawField.Size = new Size(dataSet.ItemsCount, _drawField.Width);
                sorter.SetGraphics(_drawField.CreateGraphics());
            }

            var data = new List<int>();
            for (int i = 0; i < dataSet.ItemsCount; i++)
                data.Add(random.Next(1, _drawField.Height - 1));

            _activeSortingThread = new Thread(() =>
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                var result = sorter.Execute(data);
                sw.Stop();
                MessageBox.Show($"Sorting Completed. Elapsed Time: {sw.Elapsed.Hours}:{sw.Elapsed.Minutes}:{sw.Elapsed.Seconds}:{sw.Elapsed.Milliseconds}", "Sort completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });

            _activeSortingThread.Start();
        }

        private void InitSizes()
        {
            _sizes = new List<DataSize<int>>();
            for (int i = 4; i < 15; i++)
            {
                _sizes.Add(new DataSize<int>((int)System.Math.Pow(2, i)));
            }
            _dataSizeSelector.DataSource = _sizes;
        }

        private void SelectColor(object sender, EventArgs e)
        {
            var caller = sender as Button;
            if (caller == null) return;

            var color = new ColorDialog();

            if (color.ShowDialog() == DialogResult.OK)
            {
                if (caller.Name == "_selectBgColorBtn")
                {
                    _backgroundColorView.BackColor = color.Color;
                    _bgColorViewColor = color.Color;
                }
                if (caller.Name == "_selectItemColorBtn")
                {
                    _itemColorView.BackColor = color.Color;
                    _itemColorViewColor = color.Color;
                }
            }
        }

        private void StopSortingThread(object sender, EventArgs e)
        {
            if (_activeSortingThread.IsAlive)
                _activeSortingThread.Abort();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _renderingDelay = _renderingDelayTrackbar.Value;
            _renderingDelayView.Text = _renderingDelayTrackbar.Value.ToString();
        }

        protected override void OnClosed(EventArgs e)
        {
            _activeSortingThread.Abort();
            base.OnClosed(e);
        }
    }
}
