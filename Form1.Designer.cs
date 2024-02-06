namespace Tinta {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TopPanel = new System.Windows.Forms.Panel();
            BiaLabel = new System.Windows.Forms.Label();
            ExitButton = new System.Windows.Forms.Button();
            ClearButton = new System.Windows.Forms.Button();
            SaveButton = new System.Windows.Forms.Button();
            ToolboxPanel = new System.Windows.Forms.Panel();
            AnimegirlPictureBox = new System.Windows.Forms.PictureBox();
            PencilButton = new System.Windows.Forms.PictureBox();
            ColorPickerButton = new System.Windows.Forms.PictureBox();
            PaintBrushButton = new System.Windows.Forms.PictureBox();
            RectangleButton = new System.Windows.Forms.PictureBox();
            LineButton = new System.Windows.Forms.PictureBox();
            EllipseButton = new System.Windows.Forms.PictureBox();
            EraserButton = new System.Windows.Forms.PictureBox();
            SizeSelector = new System.Windows.Forms.NumericUpDown();
            ColorBox = new System.Windows.Forms.PictureBox();
            BucketButton = new System.Windows.Forms.PictureBox();
            Pic = new System.Windows.Forms.PictureBox();
            TopPanel.SuspendLayout();
            ToolboxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AnimegirlPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PencilButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ColorPickerButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PaintBrushButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RectangleButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LineButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EllipseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EraserButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SizeSelector).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ColorBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BucketButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pic).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = System.Drawing.Color.Indigo;
            TopPanel.Controls.Add(BiaLabel);
            TopPanel.Controls.Add(ExitButton);
            TopPanel.Controls.Add(ClearButton);
            TopPanel.Controls.Add(SaveButton);
            TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            TopPanel.Location = new System.Drawing.Point(0, 0);
            TopPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new System.Drawing.Size(933, 31);
            TopPanel.TabIndex = 0;
            TopPanel.MouseDown += TopPanel_MouseDown;
            TopPanel.MouseMove += TopPanel_MouseMove;
            // 
            // BiaLabel
            // 
            BiaLabel.AutoSize = true;
            BiaLabel.BackColor = System.Drawing.Color.Transparent;
            BiaLabel.Enabled = false;
            BiaLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            BiaLabel.ForeColor = System.Drawing.Color.White;
            BiaLabel.Location = new System.Drawing.Point(4, 7);
            BiaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            BiaLabel.Name = "BiaLabel";
            BiaLabel.Size = new System.Drawing.Size(111, 16);
            BiaLabel.TabIndex = 2;
            BiaLabel.Text = "Maico-soft Tinta™";
            BiaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = System.Drawing.SystemColors.Info;
            ExitButton.Location = new System.Drawing.Point(901, 3);
            ExitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new System.Drawing.Size(24, 25);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "X";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new System.Drawing.Point(805, 2);
            ClearButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new System.Drawing.Size(88, 27);
            ClearButton.TabIndex = 4;
            ClearButton.Text = "CLEAR";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new System.Drawing.Point(709, 2);
            SaveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new System.Drawing.Size(88, 27);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "SAVE";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ToolboxPanel
            // 
            ToolboxPanel.BackColor = System.Drawing.Color.Thistle;
            ToolboxPanel.Controls.Add(AnimegirlPictureBox);
            ToolboxPanel.Controls.Add(PencilButton);
            ToolboxPanel.Controls.Add(ColorPickerButton);
            ToolboxPanel.Controls.Add(PaintBrushButton);
            ToolboxPanel.Controls.Add(RectangleButton);
            ToolboxPanel.Controls.Add(LineButton);
            ToolboxPanel.Controls.Add(EllipseButton);
            ToolboxPanel.Controls.Add(EraserButton);
            ToolboxPanel.Controls.Add(SizeSelector);
            ToolboxPanel.Controls.Add(ColorBox);
            ToolboxPanel.Controls.Add(BucketButton);
            ToolboxPanel.Dock = System.Windows.Forms.DockStyle.Left;
            ToolboxPanel.Location = new System.Drawing.Point(0, 31);
            ToolboxPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ToolboxPanel.Name = "ToolboxPanel";
            ToolboxPanel.Size = new System.Drawing.Size(80, 488);
            ToolboxPanel.TabIndex = 0;
            // 
            // AnimegirlPictureBox
            // 
            AnimegirlPictureBox.BackColor = System.Drawing.Color.Transparent;
            AnimegirlPictureBox.Image = (System.Drawing.Image)resources.GetObject("AnimegirlPictureBox.Image");
            AnimegirlPictureBox.Location = new System.Drawing.Point(4, 295);
            AnimegirlPictureBox.Name = "AnimegirlPictureBox";
            AnimegirlPictureBox.Size = new System.Drawing.Size(73, 91);
            AnimegirlPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            AnimegirlPictureBox.TabIndex = 6;
            AnimegirlPictureBox.TabStop = false;
            // 
            // PencilButton
            // 
            PencilButton.Cursor = System.Windows.Forms.Cursors.Hand;
            PencilButton.Image = Properties.Resources.Pencil;
            PencilButton.Location = new System.Drawing.Point(44, 120);
            PencilButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PencilButton.Name = "PencilButton";
            PencilButton.Size = new System.Drawing.Size(32, 32);
            PencilButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            PencilButton.TabIndex = 5;
            PencilButton.TabStop = false;
            PencilButton.Click += PencilButton_Click;
            // 
            // ColorPickerButton
            // 
            ColorPickerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            ColorPickerButton.Image = Properties.Resources.ColorPicker;
            ColorPickerButton.Location = new System.Drawing.Point(44, 44);
            ColorPickerButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ColorPickerButton.Name = "ColorPickerButton";
            ColorPickerButton.Size = new System.Drawing.Size(32, 32);
            ColorPickerButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            ColorPickerButton.TabIndex = 4;
            ColorPickerButton.TabStop = false;
            ColorPickerButton.Click += ColorPickerButton_Click;
            // 
            // PaintBrushButton
            // 
            PaintBrushButton.Cursor = System.Windows.Forms.Cursors.Hand;
            PaintBrushButton.Image = Properties.Resources.Brush;
            PaintBrushButton.Location = new System.Drawing.Point(4, 6);
            PaintBrushButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PaintBrushButton.Name = "PaintBrushButton";
            PaintBrushButton.Size = new System.Drawing.Size(32, 32);
            PaintBrushButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            PaintBrushButton.TabIndex = 1;
            PaintBrushButton.TabStop = false;
            PaintBrushButton.Click += PaintBrushButton_Click;
            // 
            // RectangleButton
            // 
            RectangleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            RectangleButton.Image = Properties.Resources.Rectangle;
            RectangleButton.Location = new System.Drawing.Point(44, 82);
            RectangleButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RectangleButton.Name = "RectangleButton";
            RectangleButton.Size = new System.Drawing.Size(32, 32);
            RectangleButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            RectangleButton.TabIndex = 3;
            RectangleButton.TabStop = false;
            RectangleButton.Click += RectangleButton_Click;
            // 
            // LineButton
            // 
            LineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            LineButton.Image = Properties.Resources.Line;
            LineButton.Location = new System.Drawing.Point(4, 120);
            LineButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LineButton.Name = "LineButton";
            LineButton.Size = new System.Drawing.Size(32, 32);
            LineButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            LineButton.TabIndex = 1;
            LineButton.TabStop = false;
            LineButton.Click += LineButton_Click;
            // 
            // EllipseButton
            // 
            EllipseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            EllipseButton.Image = Properties.Resources.Ellipse;
            EllipseButton.Location = new System.Drawing.Point(4, 82);
            EllipseButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            EllipseButton.Name = "EllipseButton";
            EllipseButton.Size = new System.Drawing.Size(32, 32);
            EllipseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            EllipseButton.TabIndex = 2;
            EllipseButton.TabStop = false;
            EllipseButton.Click += EllipseButton_Click;
            // 
            // EraserButton
            // 
            EraserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            EraserButton.Image = Properties.Resources.Eraser;
            EraserButton.Location = new System.Drawing.Point(44, 6);
            EraserButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            EraserButton.Name = "EraserButton";
            EraserButton.Size = new System.Drawing.Size(32, 32);
            EraserButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            EraserButton.TabIndex = 1;
            EraserButton.TabStop = false;
            EraserButton.Click += EraserButton_Click;
            // 
            // SizeSelector
            // 
            SizeSelector.Location = new System.Drawing.Point(13, 392);
            SizeSelector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SizeSelector.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            SizeSelector.Name = "SizeSelector";
            SizeSelector.Size = new System.Drawing.Size(56, 23);
            SizeSelector.TabIndex = 1;
            SizeSelector.Value = new decimal(new int[] { 12, 0, 0, 0 });
            SizeSelector.ValueChanged += SizeSelector_ValueChanged;
            SizeSelector.KeyUp += SizeSelector_KeyUp;
            // 
            // ColorBox
            // 
            ColorBox.BackColor = System.Drawing.Color.Black;
            ColorBox.Cursor = System.Windows.Forms.Cursors.Hand;
            ColorBox.Location = new System.Drawing.Point(13, 421);
            ColorBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ColorBox.Name = "ColorBox";
            ColorBox.Size = new System.Drawing.Size(56, 55);
            ColorBox.TabIndex = 1;
            ColorBox.TabStop = false;
            ColorBox.BackColorChanged += ColorBox_BackColorChanged;
            ColorBox.Click += ColorBox_Click;
            // 
            // BucketButton
            // 
            BucketButton.Cursor = System.Windows.Forms.Cursors.Hand;
            BucketButton.Image = Properties.Resources.Bucket;
            BucketButton.Location = new System.Drawing.Point(4, 44);
            BucketButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BucketButton.Name = "BucketButton";
            BucketButton.Size = new System.Drawing.Size(32, 32);
            BucketButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            BucketButton.TabIndex = 1;
            BucketButton.TabStop = false;
            BucketButton.Click += BucketButton_Click;
            // 
            // Pic
            // 
            Pic.BackColor = System.Drawing.Color.White;
            Pic.Cursor = System.Windows.Forms.Cursors.Cross;
            Pic.Dock = System.Windows.Forms.DockStyle.Fill;
            Pic.Location = new System.Drawing.Point(80, 31);
            Pic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Pic.Name = "Pic";
            Pic.Size = new System.Drawing.Size(853, 488);
            Pic.TabIndex = 1;
            Pic.TabStop = false;
            Pic.Click += Pic_MouseClick;
            Pic.Paint += Pic_Paint;
            Pic.MouseDown += Pic_MouseDown;
            Pic.MouseEnter += Pic_MouseEnter;
            Pic.MouseLeave += Pic_MouseLeave;
            Pic.MouseMove += Pic_MouseMove;
            Pic.MouseUp += Pic_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(Pic);
            Controls.Add(ToolboxPanel);
            Controls.Add(TopPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ToolboxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AnimegirlPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PencilButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)ColorPickerButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)PaintBrushButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)RectangleButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)LineButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)EllipseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)EraserButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)SizeSelector).EndInit();
            ((System.ComponentModel.ISupportInitialize)ColorBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BucketButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label BiaLabel;
        private System.Windows.Forms.PictureBox PaintBrushButton;
        private System.Windows.Forms.PictureBox LineButton;
        private System.Windows.Forms.PictureBox EraserButton;
        private System.Windows.Forms.PictureBox ColorBox;
        private System.Windows.Forms.PictureBox BucketButton;
        private System.Windows.Forms.PictureBox EllipseButton;
        private System.Windows.Forms.PictureBox RectangleButton;
        private System.Windows.Forms.NumericUpDown SizeSelector;
        private System.Windows.Forms.Panel ToolboxPanel;
        private System.Windows.Forms.PictureBox ColorPickerButton;
        private System.Windows.Forms.PictureBox PencilButton;
        private System.Windows.Forms.PictureBox Pic;
        private System.Windows.Forms.PictureBox AnimegirlPictureBox;
    }
}

