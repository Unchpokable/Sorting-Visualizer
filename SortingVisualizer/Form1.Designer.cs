namespace Sorting
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._algorithmSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._dataSizeSelector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._renderingDelayView = new System.Windows.Forms.Label();
            this._renderingDelayTrackbar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this._useDelayCheckbox = new System.Windows.Forms.CheckBox();
            this._selectBgColorBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this._selectItemColorBtn = new System.Windows.Forms.Button();
            this._backgroundColorView = new System.Windows.Forms.PictureBox();
            this._itemColorView = new System.Windows.Forms.PictureBox();
            this._itemColorViewLabel = new System.Windows.Forms.Label();
            this._stopSortTaskBtn = new System.Windows.Forms.Button();
            this._warningHugeDataSelected = new System.Windows.Forms.Label();
            this._warningLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this._drawField = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._renderingDelayTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._backgroundColorView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._itemColorView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._drawField)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this._stopSortTaskBtn);
            this.splitContainer1.Panel1.Controls.Add(this._warningHugeDataSelected);
            this.splitContainer1.Panel1.Controls.Add(this._warningLabel);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._drawField);
            this.splitContainer1.Size = new System.Drawing.Size(1165, 564);
            this.splitContainer1.SplitterDistance = 285;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._algorithmSelector);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this._dataSizeSelector);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(8, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 84);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sorting configuration";
            // 
            // _algorithmSelector
            // 
            this._algorithmSelector.FormattingEnabled = true;
            this._algorithmSelector.Items.AddRange(new object[] {
            "Bubble Sort",
            "QSort",
            "SortTree",
            "Insertion Sort",
            "Merge Sort",
            "Red-Black Tree Sort"});
            this._algorithmSelector.Location = new System.Drawing.Point(110, 29);
            this._algorithmSelector.Name = "_algorithmSelector";
            this._algorithmSelector.Size = new System.Drawing.Size(148, 21);
            this._algorithmSelector.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Algorithm Type:";
            // 
            // _dataSizeSelector
            // 
            this._dataSizeSelector.FormattingEnabled = true;
            this._dataSizeSelector.Items.AddRange(new object[] {
            "Small [64 B]",
            "Medium [256 B]",
            "Large [1 KiB]",
            "Extra Large [4 KiB]",
            "Rip this app [16 KiB]"});
            this._dataSizeSelector.Location = new System.Drawing.Point(110, 56);
            this._dataSizeSelector.Name = "_dataSizeSelector";
            this._dataSizeSelector.Size = new System.Drawing.Size(148, 21);
            this._dataSizeSelector.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data size:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._renderingDelayView);
            this.groupBox1.Controls.Add(this._renderingDelayTrackbar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this._useDelayCheckbox);
            this.groupBox1.Controls.Add(this._selectBgColorBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this._selectItemColorBtn);
            this.groupBox1.Controls.Add(this._backgroundColorView);
            this.groupBox1.Controls.Add(this._itemColorView);
            this.groupBox1.Controls.Add(this._itemColorViewLabel);
            this.groupBox1.Location = new System.Drawing.Point(8, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 167);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rendering Configuration";
            // 
            // _renderingDelayView
            // 
            this._renderingDelayView.AutoSize = true;
            this._renderingDelayView.Location = new System.Drawing.Point(15, 131);
            this._renderingDelayView.Name = "_renderingDelayView";
            this._renderingDelayView.Size = new System.Drawing.Size(13, 13);
            this._renderingDelayView.TabIndex = 16;
            this._renderingDelayView.Text = "0";
            // 
            // _renderingDelayTrackbar
            // 
            this._renderingDelayTrackbar.Location = new System.Drawing.Point(137, 112);
            this._renderingDelayTrackbar.Maximum = 30;
            this._renderingDelayTrackbar.Minimum = 1;
            this._renderingDelayTrackbar.Name = "_renderingDelayTrackbar";
            this._renderingDelayTrackbar.Size = new System.Drawing.Size(121, 45);
            this._renderingDelayTrackbar.TabIndex = 15;
            this._renderingDelayTrackbar.Value = 1;
            this._renderingDelayTrackbar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Rendering delay (ms):";
            // 
            // _useDelayCheckbox
            // 
            this._useDelayCheckbox.AutoSize = true;
            this._useDelayCheckbox.Location = new System.Drawing.Point(15, 90);
            this._useDelayCheckbox.Name = "_useDelayCheckbox";
            this._useDelayCheckbox.Size = new System.Drawing.Size(188, 17);
            this._useDelayCheckbox.TabIndex = 13;
            this._useDelayCheckbox.Text = "Use delay between rendering calls";
            this._useDelayCheckbox.UseVisualStyleBackColor = true;
            this._useDelayCheckbox.CheckedChanged += new System.EventHandler(this.CheckSelectedDataSize);
            // 
            // _selectBgColorBtn
            // 
            this._selectBgColorBtn.Location = new System.Drawing.Point(205, 19);
            this._selectBgColorBtn.Name = "_selectBgColorBtn";
            this._selectBgColorBtn.Size = new System.Drawing.Size(53, 23);
            this._selectBgColorBtn.TabIndex = 9;
            this._selectBgColorBtn.Text = "Select";
            this._selectBgColorBtn.UseVisualStyleBackColor = true;
            this._selectBgColorBtn.Click += new System.EventHandler(this.SelectColor);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "BG color:";
            // 
            // _selectItemColorBtn
            // 
            this._selectItemColorBtn.Location = new System.Drawing.Point(205, 46);
            this._selectItemColorBtn.Name = "_selectItemColorBtn";
            this._selectItemColorBtn.Size = new System.Drawing.Size(53, 23);
            this._selectItemColorBtn.TabIndex = 12;
            this._selectItemColorBtn.Text = "Select";
            this._selectItemColorBtn.UseVisualStyleBackColor = true;
            this._selectItemColorBtn.Click += new System.EventHandler(this.SelectColor);
            // 
            // _backgroundColorView
            // 
            this._backgroundColorView.Location = new System.Drawing.Point(91, 24);
            this._backgroundColorView.Name = "_backgroundColorView";
            this._backgroundColorView.Size = new System.Drawing.Size(108, 13);
            this._backgroundColorView.TabIndex = 8;
            this._backgroundColorView.TabStop = false;
            this._backgroundColorView.Click += new System.EventHandler(this.SelectColor);
            // 
            // _itemColorView
            // 
            this._itemColorView.Location = new System.Drawing.Point(91, 51);
            this._itemColorView.Name = "_itemColorView";
            this._itemColorView.Size = new System.Drawing.Size(108, 13);
            this._itemColorView.TabIndex = 11;
            this._itemColorView.TabStop = false;
            this._itemColorView.Click += new System.EventHandler(this.SelectColor);
            // 
            // _itemColorViewLabel
            // 
            this._itemColorViewLabel.AutoSize = true;
            this._itemColorViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._itemColorViewLabel.Location = new System.Drawing.Point(12, 49);
            this._itemColorViewLabel.Name = "_itemColorViewLabel";
            this._itemColorViewLabel.Size = new System.Drawing.Size(64, 15);
            this._itemColorViewLabel.TabIndex = 10;
            this._itemColorViewLabel.Text = "Item color:";
            // 
            // _stopSortTaskBtn
            // 
            this._stopSortTaskBtn.Location = new System.Drawing.Point(145, 526);
            this._stopSortTaskBtn.Name = "_stopSortTaskBtn";
            this._stopSortTaskBtn.Size = new System.Drawing.Size(127, 26);
            this._stopSortTaskBtn.TabIndex = 13;
            this._stopSortTaskBtn.Text = "Break";
            this._stopSortTaskBtn.UseVisualStyleBackColor = true;
            this._stopSortTaskBtn.Click += new System.EventHandler(this.StopSortingThread);
            // 
            // _warningHugeDataSelected
            // 
            this._warningHugeDataSelected.AutoSize = true;
            this._warningHugeDataSelected.ForeColor = System.Drawing.Color.Red;
            this._warningHugeDataSelected.Location = new System.Drawing.Point(11, 497);
            this._warningHugeDataSelected.Name = "_warningHugeDataSelected";
            this._warningHugeDataSelected.Size = new System.Drawing.Size(95, 13);
            this._warningHugeDataSelected.TabIndex = 6;
            this._warningHugeDataSelected.Text = "warning huge data";
            // 
            // _warningLabel
            // 
            this._warningLabel.AutoSize = true;
            this._warningLabel.ForeColor = System.Drawing.Color.Red;
            this._warningLabel.Location = new System.Drawing.Point(10, 465);
            this._warningLabel.Name = "_warningLabel";
            this._warningLabel.Size = new System.Drawing.Size(72, 13);
            this._warningLabel.TabIndex = 5;
            this._warningLabel.Text = "warning delay";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ExecuteSorting);
            // 
            // _drawField
            // 
            this._drawField.Dock = System.Windows.Forms.DockStyle.Fill;
            this._drawField.Location = new System.Drawing.Point(0, 0);
            this._drawField.Name = "_drawField";
            this._drawField.Size = new System.Drawing.Size(874, 562);
            this._drawField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this._drawField.TabIndex = 0;
            this._drawField.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 564);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Sorting Visualizer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._renderingDelayTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._backgroundColorView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._itemColorView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._drawField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox _drawField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox _dataSizeSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _algorithmSelector;
        private System.Windows.Forms.Label _warningLabel;
        private System.Windows.Forms.Label _warningHugeDataSelected;
        private System.Windows.Forms.PictureBox _itemColorView;
        private System.Windows.Forms.Label _itemColorViewLabel;
        private System.Windows.Forms.PictureBox _backgroundColorView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button _stopSortTaskBtn;
        private System.Windows.Forms.Button _selectItemColorBtn;
        private System.Windows.Forms.Button _selectBgColorBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar _renderingDelayTrackbar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox _useDelayCheckbox;
        private System.Windows.Forms.Label _renderingDelayView;
    }
}

