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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BiaLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ToolboxPanel = new System.Windows.Forms.Panel();
            this.PaintBrushButton = new System.Windows.Forms.PictureBox();
            this.RectangleButton = new System.Windows.Forms.PictureBox();
            this.LineButton = new System.Windows.Forms.PictureBox();
            this.EllipseButton = new System.Windows.Forms.PictureBox();
            this.EraserButton = new System.Windows.Forms.PictureBox();
            this.PaintbrushSize = new System.Windows.Forms.NumericUpDown();
            this.ColorBox = new System.Windows.Forms.PictureBox();
            this.BucketButton = new System.Windows.Forms.PictureBox();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopPanel.SuspendLayout();
            this.ToolboxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaintBrushButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectangleButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EllipseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EraserButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaintbrushSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BucketButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TopPanel.Controls.Add(this.BiaLabel);
            this.TopPanel.Controls.Add(this.ExitButton);
            this.TopPanel.Controls.Add(this.ClearButton);
            this.TopPanel.Controls.Add(this.SaveButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 32);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(767, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(21, 23);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BiaLabel
            // 
            this.BiaLabel.AutoSize = true;
            this.BiaLabel.BackColor = System.Drawing.Color.Transparent;
            this.BiaLabel.Enabled = false;
            this.BiaLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BiaLabel.ForeColor = System.Drawing.Color.White;
            this.BiaLabel.Location = new System.Drawing.Point(3, 7);
            this.BiaLabel.Name = "BiaLabel";
            this.BiaLabel.Size = new System.Drawing.Size(111, 16);
            this.BiaLabel.TabIndex = 2;
            this.BiaLabel.Text = "Maico-soft Tinta™";
            this.BiaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(686, 4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "CLEAR";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(605, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ToolboxPanel
            // 
            this.ToolboxPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ToolboxPanel.Controls.Add(this.PaintBrushButton);
            this.ToolboxPanel.Controls.Add(this.RectangleButton);
            this.ToolboxPanel.Controls.Add(this.LineButton);
            this.ToolboxPanel.Controls.Add(this.EllipseButton);
            this.ToolboxPanel.Controls.Add(this.EraserButton);
            this.ToolboxPanel.Controls.Add(this.PaintbrushSize);
            this.ToolboxPanel.Controls.Add(this.ColorBox);
            this.ToolboxPanel.Controls.Add(this.BucketButton);
            this.ToolboxPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolboxPanel.Location = new System.Drawing.Point(0, 32);
            this.ToolboxPanel.Name = "ToolboxPanel";
            this.ToolboxPanel.Size = new System.Drawing.Size(64, 418);
            this.ToolboxPanel.TabIndex = 0;
            // 
            // PaintBrushButton
            // 
            this.PaintBrushButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PaintBrushButton.Image = global::Tinta.Properties.Resources.Brush;
            this.PaintBrushButton.Location = new System.Drawing.Point(7, 6);
            this.PaintBrushButton.Name = "PaintBrushButton";
            this.PaintBrushButton.Size = new System.Drawing.Size(48, 48);
            this.PaintBrushButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PaintBrushButton.TabIndex = 1;
            this.PaintBrushButton.TabStop = false;
            this.PaintBrushButton.Click += new System.EventHandler(this.PaintBrushButton_Click);
            // 
            // RectangleButton
            // 
            this.RectangleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RectangleButton.Image = global::Tinta.Properties.Resources.Rectangle;
            this.RectangleButton.Location = new System.Drawing.Point(7, 222);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(48, 48);
            this.RectangleButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RectangleButton.TabIndex = 3;
            this.RectangleButton.TabStop = false;
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // LineButton
            // 
            this.LineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LineButton.Image = global::Tinta.Properties.Resources.Line;
            this.LineButton.Location = new System.Drawing.Point(7, 276);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(48, 48);
            this.LineButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LineButton.TabIndex = 1;
            this.LineButton.TabStop = false;
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // EllipseButton
            // 
            this.EllipseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EllipseButton.Image = global::Tinta.Properties.Resources.Ellipse;
            this.EllipseButton.Location = new System.Drawing.Point(7, 168);
            this.EllipseButton.Name = "EllipseButton";
            this.EllipseButton.Size = new System.Drawing.Size(48, 48);
            this.EllipseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EllipseButton.TabIndex = 2;
            this.EllipseButton.TabStop = false;
            this.EllipseButton.Click += new System.EventHandler(this.EllipseButton_Click);
            // 
            // EraserButton
            // 
            this.EraserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EraserButton.Image = global::Tinta.Properties.Resources.Eraser;
            this.EraserButton.Location = new System.Drawing.Point(7, 60);
            this.EraserButton.Name = "EraserButton";
            this.EraserButton.Size = new System.Drawing.Size(48, 48);
            this.EraserButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EraserButton.TabIndex = 1;
            this.EraserButton.TabStop = false;
            this.EraserButton.Click += new System.EventHandler(this.EraserButton_Click);
            // 
            // PaintbrushSize
            // 
            this.PaintbrushSize.Location = new System.Drawing.Point(7, 332);
            this.PaintbrushSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PaintbrushSize.Name = "PaintbrushSize";
            this.PaintbrushSize.Size = new System.Drawing.Size(48, 20);
            this.PaintbrushSize.TabIndex = 1;
            this.PaintbrushSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.PaintbrushSize.ValueChanged += new System.EventHandler(this.PaintbrushSize_ValueChanged);
            this.PaintbrushSize.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PaintbrushSize_KeyUp);
            // 
            // ColorBox
            // 
            this.ColorBox.BackColor = System.Drawing.Color.Black;
            this.ColorBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorBox.Location = new System.Drawing.Point(7, 358);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(48, 48);
            this.ColorBox.TabIndex = 1;
            this.ColorBox.TabStop = false;
            this.ColorBox.Click += new System.EventHandler(this.ColorBox_Click);
            // 
            // BucketButton
            // 
            this.BucketButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BucketButton.Image = global::Tinta.Properties.Resources.Bucket;
            this.BucketButton.Location = new System.Drawing.Point(7, 114);
            this.BucketButton.Name = "BucketButton";
            this.BucketButton.Size = new System.Drawing.Size(48, 48);
            this.BucketButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BucketButton.TabIndex = 1;
            this.BucketButton.TabStop = false;
            this.BucketButton.Click += new System.EventHandler(this.BucketButton_Click);
            // 
            // Pic
            // 
            this.Pic.BackColor = System.Drawing.Color.White;
            this.Pic.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pic.Location = new System.Drawing.Point(64, 32);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(736, 418);
            this.Pic.TabIndex = 1;
            this.Pic.TabStop = false;
            this.Pic.Click += new System.EventHandler(this.Pic_MouseClick);
            this.Pic.Paint += new System.Windows.Forms.PaintEventHandler(this.Pic_Paint);
            this.Pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseDown);
            this.Pic.MouseEnter += new System.EventHandler(this.Pic_MouseEnter);
            this.Pic.MouseLeave += new System.EventHandler(this.Pic_MouseLeave);
            this.Pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseMove);
            this.Pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::Tinta.Properties.Resources.anime_girl_pencil;
            this.pictureBox1.Location = new System.Drawing.Point(678, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Pic);
            this.Controls.Add(this.ToolboxPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ToolboxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PaintBrushButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectangleButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LineButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EllipseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EraserButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaintbrushSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BucketButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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

