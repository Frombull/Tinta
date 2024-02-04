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

        Bitmap bitmap;

        bool isMouseDown = false;
        bool drawBrushOutline = true;
        private Point mouseOffsetPos;
        short toolIndex = 0;
        int pressedX, pressedY;
        int x, y;

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
            Pic.Invalidate();
        }

        private void Pic_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;

            if (isMouseDown) {
                switch (toolIndex) {
                    case 3:
                        g.DrawEllipse(pen, pressedX, pressedY, x - pressedX, y - pressedY);
                        break;
                    case 4:
                        g.DrawRectangle(pen, pressedX, pressedY, x - pressedX, y - pressedY);
                        break;
                    case 5:
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

        private void Pic_MouseDown(object sender, MouseEventArgs e) {
            isMouseDown = true;
            pressedX = e.X;
            pressedY = e.Y;
            last = e.Location;
        }

        private void Pic_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                switch (toolIndex) {
                    case 0:
                        current = e.Location;
                        g.DrawLine(pen, last, current);
                        last = current;
                        break;
                    case 1:
                        current = e.Location;
                        g.DrawLine(eraserPen, last, current);
                        last = current;
                        break;
                    case 2:
                    case 3:
                    case 4:
                    case 5:
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
                case 3:
                    g.DrawEllipse(pen, pressedX, pressedY, e.X - pressedX, e.Y - pressedY);
                    break;
                case 4:
                    g.DrawRectangle(pen, pressedX, pressedY, e.X - pressedX, e.Y - pressedY);
                    break;
                case 5:
                    g.DrawLine(pen, pressedX, pressedY, e.X, e.Y);
                    break;
                default: 
                    break;
            }
        }

        private void Pic_MouseClick(object sender, EventArgs e) {
            switch (toolIndex) {
                case 2: // Bucket   //TODO: mexe aqui sla
                    Point point = SetPoint(Pic, x, y);
                    FloodFill(bitmap, point.X, point.Y, pen.Color);
                    Pic.Refresh();
                    break;
                default:
                    break;
            }
        }

        private void Pic_MouseEnter(object sender, EventArgs e) {
            drawBrushOutline = true;
            Pic.Refresh();
        }

        private void Pic_MouseLeave(object sender, EventArgs e) {
            drawBrushOutline = false;
            Pic.Refresh();
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
            toolIndex = 1;
            ColorBox.BackColor = eraserPen.Color;
            PaintbrushSize.Value = (decimal)eraserPen.Width;
        }

        private void BucketButton_Click(object sender, EventArgs e) {
            toolIndex = 2;
            ColorBox.BackColor = pen.Color;
            PaintbrushSize.Value = (decimal)pen.Width;
        }

        private void EllipseButton_Click(object sender, EventArgs e) {
            toolIndex = 3;
            ColorBox.BackColor = pen.Color;
            PaintbrushSize.Value = (decimal)pen.Width;

        }

        private void RectangleButton_Click(object sender, EventArgs e) {
            toolIndex = 4;
            ColorBox.BackColor = pen.Color;
            PaintbrushSize.Value = (decimal)pen.Width;

        }

        private void LineButton_Click(object sender, EventArgs e) {
            toolIndex = 5;
            ColorBox.BackColor = pen.Color;
            PaintbrushSize.Value = (decimal)pen.Width;

        }

        private void PaintbrushSize_KeyUp(object sender, KeyEventArgs e) { // TODO: deselect box
            PaintbrushSize_ValueChanged(sender, e);
        }

        private void PaintbrushSize_ValueChanged(object sender, EventArgs e) {
            switch (toolIndex) {
                case 0:
                    pen.Width = (float)PaintbrushSize.Value;
                    break;
                case 1:
                    eraserPen.Width = (float)PaintbrushSize.Value;
                    break;
                case 2: // Bucket
                    break;
                case 3:
                    pen.Width = (float)PaintbrushSize.Value;
                    break;
                case 4:
                    pen.Width = (float)PaintbrushSize.Value;
                    break;
                case 5:
                    break;
                default:
                    break;
            }
        }

        private void ColorBox_Click(object sender, EventArgs e) { //TODO: Set starting position
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK) {
                pen.Color = cd.Color;
                ColorBox.BackColor = cd.Color;
            }
        }

        private Point SetPoint(PictureBox Pic, int x, int y) {
            float pointX = 1f * Pic.Width / Pic.Width;
            float pointY = 1f * Pic.Height / Pic.Height;
            return new Point((int)(x * pointX), (int)(y * pointY));
        }

        private void Validate(Bitmap bitmap, Stack<Point> pixel, int x, int y, Color oldColor, Color newColor) {
            Color cx = bitmap.GetPixel(x, y);

            if (cx == oldColor) {
                pixel.Push(new Point(x, y));
                bitmap.SetPixel(x, y, newColor);
            }
        }

        private void FloodFill(Bitmap bitmap, int x, int y, Color newColor) {
            Color oldColor = bitmap.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));

            if (oldColor.Equals(newColor))
                return;

            bitmap.SetPixel(x, y, newColor);

            while (pixel.Count > 0) {
                Point point = pixel.Pop();
                if (point.X > 0 && point.Y > 0 && point.X < bitmap.Width - 1 && point.Y < bitmap.Height - 1) {
                    Validate(bitmap, pixel, point.X - 1, point.Y, oldColor, newColor);
                    Validate(bitmap, pixel, point.X, point.Y - 1, oldColor, newColor);
                    Validate(bitmap, pixel, point.X + 1, point.Y, oldColor, newColor);
                    Validate(bitmap, pixel, point.X, point.Y + 1, oldColor, newColor);
                }
            }
        }
    }
}
