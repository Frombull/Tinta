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
            TopPanel = new System.Windows.Forms.Panel();
            BiaLabel = new System.Windows.Forms.Label();
            ExitButton = new System.Windows.Forms.Button();
            ClearButton = new System.Windows.Forms.Button();
            SaveButton = new System.Windows.Forms.Button();
            ToolboxPanel = new System.Windows.Forms.Panel();
            PaintBrushButton = new System.Windows.Forms.PictureBox();
            RectangleButton = new System.Windows.Forms.PictureBox();
            LineButton = new System.Windows.Forms.PictureBox();
            EllipseButton = new System.Windows.Forms.PictureBox();
            EraserButton = new System.Windows.Forms.PictureBox();
            PaintbrushSize = new System.Windows.Forms.NumericUpDown();
            ColorBox = new System.Windows.Forms.PictureBox();
            BucketButton = new System.Windows.Forms.PictureBox();
            Pic = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            TopPanel.SuspendLayout();
            ToolboxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PaintBrushButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RectangleButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LineButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EllipseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EraserButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PaintbrushSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ColorBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BucketButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            TopPanel.Size = new System.Drawing.Size(933, 37);
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
            BiaLabel.Location = new System.Drawing.Point(4, 10);
            BiaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            BiaLabel.Name = "BiaLabel";
            BiaLabel.Size = new System.Drawing.Size(111, 16);
            BiaLabel.TabIndex = 2;
            BiaLabel.Text = "Maico-soft Tinta™";
            BiaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitButton
            // 
            ExitButton.Location = new System.Drawing.Point(895, 5);
            ExitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new System.Drawing.Size(24, 27);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "X";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new System.Drawing.Point(800, 5);
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
            SaveButton.Location = new System.Drawing.Point(706, 5);
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
            ToolboxPanel.Controls.Add(PaintBrushButton);
            ToolboxPanel.Controls.Add(RectangleButton);
            ToolboxPanel.Controls.Add(LineButton);
            ToolboxPanel.Controls.Add(EllipseButton);
            ToolboxPanel.Controls.Add(EraserButton);
            ToolboxPanel.Controls.Add(PaintbrushSize);
            ToolboxPanel.Controls.Add(ColorBox);
            ToolboxPanel.Controls.Add(BucketButton);
            ToolboxPanel.Dock = System.Windows.Forms.DockStyle.Left;
            ToolboxPanel.Location = new System.Drawing.Point(0, 37);
            ToolboxPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ToolboxPanel.Name = "ToolboxPanel";
            ToolboxPanel.Size = new System.Drawing.Size(75, 482);
            ToolboxPanel.TabIndex = 0;
            // 
            // PaintBrushButton
            // 
            PaintBrushButton.Cursor = System.Windows.Forms.Cursors.Hand;
            PaintBrushButton.Image = Properties.Resources.Brush;
            PaintBrushButton.Location = new System.Drawing.Point(8, 7);
            PaintBrushButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PaintBrushButton.Name = "PaintBrushButton";
            PaintBrushButton.Size = new System.Drawing.Size(56, 55);
            PaintBrushButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            PaintBrushButton.TabIndex = 1;
            PaintBrushButton.TabStop = false;
            PaintBrushButton.Click += PaintBrushButton_Click;
            // 
            // RectangleButton
            // 
            RectangleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            RectangleButton.Image = Properties.Resources.Rectangle;
            RectangleButton.Location = new System.Drawing.Point(8, 256);
            RectangleButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RectangleButton.Name = "RectangleButton";
            RectangleButton.Size = new System.Drawing.Size(56, 55);
            RectangleButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            RectangleButton.TabIndex = 3;
            RectangleButton.TabStop = false;
            RectangleButton.Click += RectangleButton_Click;
            // 
            // LineButton
            // 
            LineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            LineButton.Image = Properties.Resources.Line;
            LineButton.Location = new System.Drawing.Point(8, 318);
            LineButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LineButton.Name = "LineButton";
            LineButton.Size = new System.Drawing.Size(56, 55);
            LineButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            LineButton.TabIndex = 1;
            LineButton.TabStop = false;
            LineButton.Click += LineButton_Click;
            // 
            // EllipseButton
            // 
            EllipseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            EllipseButton.Image = Properties.Resources.Ellipse;
            EllipseButton.Location = new System.Drawing.Point(8, 194);
            EllipseButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            EllipseButton.Name = "EllipseButton";
            EllipseButton.Size = new System.Drawing.Size(56, 55);
            EllipseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            EllipseButton.TabIndex = 2;
            EllipseButton.TabStop = false;
            EllipseButton.Click += EllipseButton_Click;
            // 
            // EraserButton
            // 
            EraserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            EraserButton.Image = Properties.Resources.Eraser;
            EraserButton.Location = new System.Drawing.Point(8, 69);
            EraserButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            EraserButton.Name = "EraserButton";
            EraserButton.Size = new System.Drawing.Size(56, 55);
            EraserButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            EraserButton.TabIndex = 1;
            EraserButton.TabStop = false;
            EraserButton.Click += EraserButton_Click;
            // 
            // PaintbrushSize
            // 
            PaintbrushSize.Location = new System.Drawing.Point(8, 383);
            PaintbrushSize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PaintbrushSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            PaintbrushSize.Name = "PaintbrushSize";
            PaintbrushSize.Size = new System.Drawing.Size(56, 23);
            PaintbrushSize.TabIndex = 1;
            PaintbrushSize.Value = new decimal(new int[] { 32, 0, 0, 0 });
            PaintbrushSize.ValueChanged += PaintbrushSize_ValueChanged;
            PaintbrushSize.KeyUp += PaintbrushSize_KeyUp;
            // 
            // ColorBox
            // 
            ColorBox.BackColor = System.Drawing.Color.Black;
            ColorBox.Cursor = System.Windows.Forms.Cursors.Hand;
            ColorBox.Location = new System.Drawing.Point(8, 413);
            ColorBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ColorBox.Name = "ColorBox";
            ColorBox.Size = new System.Drawing.Size(56, 55);
            ColorBox.TabIndex = 1;
            ColorBox.TabStop = false;
            ColorBox.Click += ColorBox_Click;
            // 
            // BucketButton
            // 
            BucketButton.Cursor = System.Windows.Forms.Cursors.Hand;
            BucketButton.Image = Properties.Resources.Bucket;
            BucketButton.Location = new System.Drawing.Point(8, 132);
            BucketButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            BucketButton.Name = "BucketButton";
            BucketButton.Size = new System.Drawing.Size(56, 55);
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
            Pic.Location = new System.Drawing.Point(75, 37);
            Pic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Pic.Name = "Pic";
            Pic.Size = new System.Drawing.Size(858, 482);
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
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.White;
            pictureBox1.Enabled = false;
            pictureBox1.Image = Properties.Resources.anime_girl_pencil;
            pictureBox1.Location = new System.Drawing.Point(791, 352);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(142, 167);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)PaintBrushButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)RectangleButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)LineButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)EllipseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)EraserButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)PaintbrushSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)ColorBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BucketButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.NumericUpDown PaintbrushSize;
        private System.Windows.Forms.PictureBox Pic;
        private System.Windows.Forms.Panel ToolboxPanel;
    }
}

