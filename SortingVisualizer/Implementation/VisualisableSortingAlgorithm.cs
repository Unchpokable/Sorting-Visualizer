using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sorting.Implementation
{
    internal abstract class VisualisableSortingAlgorithm: ISortingAlgorithm<int>
    {
        protected VisualisableSortingAlgorithm(SortingAlgorithmType type, Graphics gpraphics)
        {
            Type = type;
            _graphics = gpraphics;
        }

        public SortingAlgorithmType Type { get; private set; }
        public int PixelsPerUnit { get; set; }
        public int MaxHeight { get; set; }
        public int DrawTimeout { get; set; }
        public Color BackgroundColor { get; set; }
        public Color ItemColor { get; set; }


        //Ye, i know that "protected" is kinda breaks incapsulation, but i need this field in derived classes and dont want use property
        protected Graphics _graphics;
        protected IList<int> _collection;

        public virtual IList<int> Execute(IList<int> collection)
        {
            throw new NotImplementedException($"Execute isn't overrided in type {this.GetType()}");
        }

        public void SetGraphics(Graphics graphics)
        {
            if (graphics == null)
                throw new NullReferenceException("Trying to set null graphics object");
            _graphics = graphics;
        }

        protected void DrawBar(int position, bool useDelay = true)
        {
            if (useDelay && DrawTimeout > 0)
                WaitForSeconds((float)DrawTimeout / 1000);
            var height = _collection[position];
            _graphics.FillRectangle(new SolidBrush(BackgroundColor), position * PixelsPerUnit, 0, PixelsPerUnit, MaxHeight);
            _graphics.FillRectangle(new SolidBrush(ItemColor), position * PixelsPerUnit, 0, PixelsPerUnit, height);
        }

        protected void ReDraw(bool useDelay = false)
        {
            if (_collection == null)
                throw new NullReferenceException("Try to draw null array");
            _graphics.Clear(BackgroundColor);
            for (int i = 0; i < _collection.Count; i++)
                DrawBarSimple(i, useDelay: useDelay, delay: DrawTimeout);
        }

        protected void WaitForSeconds(float sec)
        {
            var durationTicks = Math.Round(sec * Stopwatch.Frequency);
            var sw = Stopwatch.StartNew();
            while (sw.ElapsedTicks < durationTicks)
            {

            }
        }

        private void DrawBarSimple(int position, bool useDelay = false, int delay = 10)
        {
            if (useDelay)
                WaitForSeconds((float)DrawTimeout / 1000);
            var height = _collection[position];
            _graphics.FillRectangle(new SolidBrush(ItemColor), position * PixelsPerUnit, 0, PixelsPerUnit, height);
        }
    }
}
