using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tinta {
    public partial class Form1 : Form {
        public Point current = new Point();
        public Point last = new Point();

        public Graphics g;

        public Pen pen = new Pen(Color.Black, 3);
        public Pen eraserPen = new Pen(Color.White, 3);
        public Pen outlinePen = new Pen(Color.Black, 1);

        readonly Bitmap bitmap;

        bool isMouseDown = false;
        bool drawBrushOutline = true;
        private Point mouseOffsetPos;
        int pressedX, pressedY;
        int x, y;

        public enum DrawingTool {
            Paintbrush = 0,
            Eraser = 1,
            Bucket = 2,
            Ellipse = 3,
            Rectangle = 4,
            Line = 5
        }

        private DrawingTool toolIndex = DrawingTool.Paintbrush;

        public Form1() {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.Opaque | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            InitializeComponent();
            g = Pic.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            pen.Width = (float)PaintbrushSize.Value;
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round,
                           System.Drawing.Drawing2D.LineCap.Round,
                           System.Drawing.Drawing2D.DashCap.Round);

            eraserPen.Width = (float)PaintbrushSize.Value;
            eraserPen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round,
                           System.Drawing.Drawing2D.LineCap.Round,
                           System.Drawing.Drawing2D.DashCap.Round);

            bitmap = new Bitmap(Pic.Width, Pic.Height);

            g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);

            Pic.BackgroundImage = bitmap;
            Pic.MouseWheel += Pic_MouseWheel;
            Pic.Invalidate();
        }

        private void Pic_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;

            if (isMouseDown) {
                switch (toolIndex) {
                    case DrawingTool.Ellipse:
                        g.DrawEllipse(pen, pressedX, pressedY, x - pressedX, y - pressedY);
                        break;
                    case DrawingTool.Rectangle:
                        g.DrawRectangle(pen, pressedX, pressedY, x - pressedX, y - pressedY);
                        break;
                    case DrawingTool.Line:
                        g.DrawLine(pen, pressedX, pressedY, x, y);
                        break;
                    default:
                        break;
                }
            }
            if (drawBrushOutline) {
                g.DrawEllipse(outlinePen,
                                x - ((float)PaintbrushSize.Value / 2.0f),
                                y - ((float)PaintbrushSize.Value / 2.0f),
                                (float)PaintbrushSize.Value,
                                (float)PaintbrushSize.Value);
            }
        }

        private void Pic_MouseWheel(object sender, MouseEventArgs e) {
            if (toolIndex == DrawingTool.Bucket)   // Bucket
                return;
           
            if (e.Delta > 0 && PaintbrushSize.Value > PaintbrushSize.Minimum) {         // Scroll Up
                PaintbrushSize.Value -= 1;
                Pic.Refresh();
            }
            else if (e.Delta < 0 && PaintbrushSize.Value < PaintbrushSize.Maximum) {    // Scroll Down
                PaintbrushSize.Value += 1;
                Pic.Refresh();
            }
        }

        private void Pic_MouseDown(object sender, MouseEventArgs e) {
            isMouseDown = true;
            pressedX = e.X;
            pressedY = e.Y;
            last = e.Location;

            // Deselect 'PaintbrushSize'
            PaintbrushSize.Enabled = false;
            PaintbrushSize.Enabled = true;
        }

        private void Pic_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                switch (toolIndex) {
                    case DrawingTool.Paintbrush:
                        current = e.Location;
                        g.DrawLine(pen, last, current);
                        last = current;
                        break;
                    case DrawingTool.Eraser:
                        current = e.Location;
                        g.DrawLine(eraserPen, last, current);
                        last = current;
                        break;
                    default:
                        break;
                }
            }

            x = e.X;
            y = e.Y;

            Pic.Refresh();
        }

        private void Pic_MouseUp(object sender, MouseEventArgs e) {
            isMouseDown = false;
            switch (toolIndex) {
                case DrawingTool.Ellipse:
                    g.DrawEllipse(pen, pressedX, pressedY, e.X - pressedX, e.Y - pressedY);
                    break;
                case DrawingTool.Rectangle:
                    g.DrawRectangle(pen, pressedX, pressedY, e.X - pressedX, e.Y - pressedY);
                    break;
                case DrawingTool.Line:
                    g.DrawLine(pen, pressedX, pressedY, e.X, e.Y);
                    break;
                default: 
                    break;
            }
        }

        private void Pic_MouseClick(object sender, EventArgs e) {
            switch (toolIndex) {
                case DrawingTool.Bucket:
                    FloodFill(bitmap, x, y, pen.Color);
                    Pic.Refresh();
                    break;
                default:
                    break;
            }
        }

        private void Pic_MouseEnter(object sender, EventArgs e) {
            if (toolIndex != DrawingTool.Bucket) {
                drawBrushOutline = true;
                Pic.Refresh();
            }
        }

        private void Pic_MouseLeave(object sender, EventArgs e) {
            if (toolIndex != DrawingTool.Bucket) {
                drawBrushOutline = false;
                Pic.Refresh();
            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                mouseOffsetPos = new Point(-e.X, -e.Y);
            }
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e) {  // Drag the window arround
            if (e.Button == MouseButtons.Left) {
                Point mousePos = MousePosition;
                mousePos.Offset(mouseOffsetPos.X, mouseOffsetPos.Y);
                this.Location = mousePos;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e) { //TODO: make it have a default name "unknown.png" or something
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Png Files (*png) | *.png";
            saveFileDialog.DefaultExt = "png";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                bitmap.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }
        
        private void ClearButton_Click(object sender, EventArgs e) {
            var confirmResult = MessageBox.Show("Clear canvas?", "Maico-soft Tinta™",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (confirmResult == DialogResult.Yes) {
                g.Clear(Color.White);
                Pic.Invalidate();
            }
        }
        
        private void ExitButton_Click(object sender, EventArgs e) {
            var confirmResult = MessageBox.Show("Save changes before quitting?", "Maico-soft Tinta™",
                         MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes) {
                SaveButton_Click(sender, e);
                this.Close();
            }
            else if (confirmResult == DialogResult.No) {
                this.Close();
            }
            else if (confirmResult == DialogResult.Cancel) {
                return;
            }
        }
        
        private void PaintBrushButton_Click(object sender, EventArgs e) {
            toolIndex = 0;
            ColorBox.BackColor = pen.Color;
            PaintbrushSize.Value = (decimal)pen.Width;
        }
        
        private void EraserButton_Click(object sender, EventArgs e) {
            toolIndex = DrawingTool.Eraser;
            ColorBox.BackColor = eraserPen.Color;
            PaintbrushSize.Value = (decimal)eraserPen.Width;
        }

        private void BucketButton_Click(object sender, EventArgs e) {
            toolIndex = DrawingTool.Bucket;
            ColorBox.BackColor = pen.Color;
            PaintbrushSize.Value = (decimal)pen.Width;
            drawBrushOutline = false;
        }

        private void EllipseButton_Click(object sender, EventArgs e) {
            toolIndex = DrawingTool.Ellipse;
            ColorBox.BackColor = pen.Color;
            PaintbrushSize.Value = (decimal)pen.Width;
        }

        private void RectangleButton_Click(object sender, EventArgs e) {
            toolIndex = DrawingTool.Rectangle;
            ColorBox.BackColor = pen.Color;
            PaintbrushSize.Value = (decimal)pen.Width;
        }

        private void LineButton_Click(object sender, EventArgs e) {
            toolIndex = DrawingTool.Line;
            ColorBox.BackColor = pen.Color;
            PaintbrushSize.Value = (decimal)pen.Width;
        }

        private void PaintbrushSize_KeyUp(object sender, KeyEventArgs e) { // TODO: deselect box
            PaintbrushSize_ValueChanged(sender, e);
        }

        private void PaintbrushSize_ValueChanged(object sender, EventArgs e) {
            switch (toolIndex) {
                case DrawingTool.Paintbrush:
                    pen.Width = (float)PaintbrushSize.Value;
                    break;
                case DrawingTool.Eraser:
                    eraserPen.Width = (float)PaintbrushSize.Value;
                    break;
                case DrawingTool.Bucket:
                    break;
                case DrawingTool.Ellipse:
                    pen.Width = (float)PaintbrushSize.Value;
                    break;
                case DrawingTool.Rectangle:
                    pen.Width = (float)PaintbrushSize.Value;
                    break;
                case DrawingTool.Line:
                    break;
                default:
                    break;
            }
        }

        private void ColorBox_Click(object sender, EventArgs e) { //TODO: Set starting position
            ColorDialog cd = new();
            if (cd.ShowDialog() == DialogResult.OK) {
                pen.Color = cd.Color;
                ColorBox.BackColor = cd.Color;
            }
        }

        private static void FloodFill(Bitmap bitmap, int x, int y, Color newColor) {
            Color oldColor = bitmap.GetPixel(x, y);

            if (oldColor.ToArgb() == newColor.ToArgb())
                return;

            Queue<Point> pixels = new Queue<Point>();
            pixels.Enqueue(new Point(x, y));
            bitmap.SetPixel(x, y, newColor);

            while (pixels.Count > 0) {
                Point pixel = pixels.Dequeue();
                int px = pixel.X;
                int py = pixel.Y;

                if (px > 0 && py > 0 && px < bitmap.Width - 1 && py < bitmap.Height - 1) {
                    Validate(bitmap, pixels, px - 1, py, oldColor, newColor);
                    Validate(bitmap, pixels, px, py - 1, oldColor, newColor);
                    Validate(bitmap, pixels, px + 1, py, oldColor, newColor);
                    Validate(bitmap, pixels, px, py + 1, oldColor, newColor);
                }
            }
        }

        private static void Validate(Bitmap bitmap, Queue<Point> pixels, int x, int y, Color oldColor, Color newColor) {
            Color currentColor = bitmap.GetPixel(x, y);

            if (currentColor != oldColor)
                return;

            pixels.Enqueue(new Point(x, y));
            bitmap.SetPixel(x, y, newColor);
        }
    }
}
