using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Drawing;
using System;
using Microsoft.VisualBasic.Devices;

namespace Tinta {
    public partial class Form1 : Form {
        private Point last = new Point();
        private Point current = new Point();

        private Graphics g;

        static private Pen pen = new Pen(Color.Black, 1);
        static private Pen pencil = new Pen(Color.Black, 1);
        static private Pen eraserPen = new Pen(Color.White, 1);
        static private Pen outlinePen = new Pen(Color.Black, 1);

        private readonly Bitmap bitmap;

        Point mouseOffsetPos;

        bool drawBrushOutline = true;
        bool wasDrawingBrushOutline = true;

        bool isMouseDown = false;
        int pressedX, pressedY;
        int mouseX, mouseY;

        bool drawingPolygon = false;
        int PolygonX, PolygonY;

        public enum DrawingTool {
            Pencil,
            Paintbrush,
            Eraser,
            Bucket,
            Ellipse,
            Rectangle,
            Line,
            ColorPicker,
            Polygon,
            Airbrush
        }

        static private DrawingTool selectedTool = DrawingTool.Paintbrush;

        public Form1() {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.Opaque | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            InitializeComponent();
            g = Pic.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            pen.Width = (float)SizeSelector.Value;
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round,
                           System.Drawing.Drawing2D.LineCap.Round,
                           System.Drawing.Drawing2D.DashCap.Round);

            eraserPen.Width = (float)SizeSelector.Value;
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

        private void Pic_Paint(object sender, PaintEventArgs p) {
            Graphics g = p.Graphics;

            if (isMouseDown) {
                switch (selectedTool) {
                    case DrawingTool.Ellipse:
                        if (ModifierKeys == (Keys.Shift | Keys.Alt)) {
                            // Perfect circle and center at mouse
                            int diameter = Math.Min(Math.Abs(mouseX - pressedX), Math.Abs(mouseY - pressedY)) * 2;
                            int x = pressedX - diameter / 2;
                            int y = pressedY - diameter / 2;
                            g.DrawEllipse(pen, x, y, diameter, diameter);
                        }
                        else if (ModifierKeys == Keys.Alt) {
                            // Ellipse center at mouse
                            int width = Math.Abs(mouseX - pressedX) * 2;
                            int height = Math.Abs(mouseY - pressedY) * 2;
                            int x = pressedX - width / 2;
                            int y = pressedY - height / 2;
                            g.DrawEllipse(pen, x, y, width, height);
                        }
                        else if (ModifierKeys == Keys.Shift) {
                            // Perfect circle
                            int diameter = Math.Min(Math.Abs(mouseX - pressedX), Math.Abs(mouseY - pressedY));
                            int x = pressedX + (mouseX > pressedX ? 0 : -diameter);
                            int y = pressedY + (mouseY > pressedY ? 0 : -diameter);
                            g.DrawEllipse(pen, x, y, diameter, diameter);
                        }
                        else {
                            g.DrawEllipse(pen, pressedX, pressedY, mouseX - pressedX, mouseY - pressedY);
                        }
                        break;
                    case DrawingTool.Rectangle:
                        g.DrawRectangle(pen, Math.Min(pressedX, mouseX), Math.Min(pressedY, mouseY), Math.Abs(mouseX - pressedX), Math.Abs(mouseY - pressedY));
                        break;
                    case DrawingTool.Line:
                        g.DrawLine(pen, pressedX, pressedY, mouseX, mouseY);
                        break;
                    case DrawingTool.Polygon:
                        if (drawingPolygon)
                            g.DrawLine(pen, PolygonX, PolygonY, mouseX, mouseY);
                        else
                            g.DrawLine(pen, pressedX, pressedY, mouseX, mouseY);
                        break;
                    case DrawingTool.Airbrush:
                        Random rand = new Random();
                        int airbrushDensity = 8;

                        for (int i = 0; i < airbrushDensity; i++) {
                            float angle = (float)(rand.NextDouble() * 2.0f * 3.14f);
                            float radius = (float)(rand.NextDouble() * pen.Width);

                            int offsetX = (int)(radius * Math.Cos(angle));
                            int offsetY = (int)(radius * Math.Sin(angle));

                            int airbrushX = mouseX + offsetX / 2;
                            int airbrushY = mouseY + offsetY / 2;

                            if (airbrushX >= 0 && airbrushX < bitmap.Width && airbrushY >= 0 && airbrushY < bitmap.Height) {
                                bitmap.SetPixel(airbrushX, airbrushY, pen.Color);
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
            if (drawBrushOutline) {
                g.DrawEllipse(outlinePen,
                                mouseX - ((float)SizeSelector.Value / 2.0f),
                                mouseY - ((float)SizeSelector.Value / 2.0f),
                                (float)SizeSelector.Value,
                                (float)SizeSelector.Value);
            }
        }

        private void Pic_MouseWheel(object sender, MouseEventArgs e) {
            if (selectedTool == DrawingTool.Bucket || selectedTool == DrawingTool.ColorPicker || selectedTool == DrawingTool.Pencil)
                return;

            if (e.Delta > 0 && SizeSelector.Value > SizeSelector.Minimum) {         // Scroll Up
                SizeSelector.Value -= 1;
                Pic.Refresh();
            }
            else if (e.Delta < 0 && SizeSelector.Value < SizeSelector.Maximum) {    // Scroll Down
                SizeSelector.Value += 1;
                Pic.Refresh();
            }
        }

        private void Pic_MouseDown(object sender, MouseEventArgs e) {
            isMouseDown = true;
            pressedX = e.X;
            pressedY = e.Y;
            last = e.Location;

            // Deselect 'SizeSelector'
            SizeSelector.Enabled = !SizeSelector.Enabled;
            SizeSelector.Enabled = !SizeSelector.Enabled;
        }

        private void Pic_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                switch (selectedTool) {
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
                    case DrawingTool.Pencil:
                        current = e.Location;
                        g.DrawLine(pencil, last, current);
                        last = current;
                        break;
                    case DrawingTool.ColorPicker:
                        if (mouseX < Pic.Width && mouseX > 0 && mouseY < Pic.Height && mouseY > 0) {
                            ColorBox.BackColor = bitmap.GetPixel(mouseX, mouseY);
                        }
                        break;
                    default:
                        break;
                }
            }

            mouseX = e.X;
            mouseY = e.Y;

            Pic.Refresh();
        }

        private void Pic_MouseUp(object sender, MouseEventArgs e) {
            isMouseDown = false;
            switch (selectedTool) {
                case DrawingTool.Ellipse:
                    if (ModifierKeys == (Keys.Shift | Keys.Alt)) {
                        // MAKE SO ITS A PRFECT CIRCLE EVERY TIME AND ITS CENTER IS WHERE I CLICKED
                        int diameter = Math.Min(Math.Abs(mouseX - pressedX), Math.Abs(mouseY - pressedY)) * 2;
                        int x = pressedX - diameter / 2;
                        int y = pressedY - diameter / 2;
                        g.DrawEllipse(pen, x, y, diameter, diameter);
                    }
                    else if (ModifierKeys == Keys.Alt) {
                        // --OK-- MAKE SO THE CIRCLE CENTER IS WHERE I CLICKED AND IT CAN GROW LIKE A NORMAL ELLIPSE
                        int width = Math.Abs(mouseX - pressedX) * 2;
                        int height = Math.Abs(mouseY - pressedY) * 2;
                        int x = pressedX - width / 2;
                        int y = pressedY - height / 2;
                        g.DrawEllipse(pen, x, y, width, height);
                    }
                    else if (ModifierKeys == Keys.Shift) {
                        // --OK-- MAKE SO ITS A PRFECT CIRCLE EVERY TIME
                        int diameter = Math.Min(Math.Abs(mouseX - pressedX), Math.Abs(mouseY - pressedY));
                        int x = pressedX + (mouseX > pressedX ? 0 : -diameter);
                        int y = pressedY + (mouseY > pressedY ? 0 : -diameter);
                        g.DrawEllipse(pen, x, y, diameter, diameter);
                    }
                    else {
                        g.DrawEllipse(pen, pressedX, pressedY, mouseX - pressedX, mouseY - pressedY);
                    }
                    break;
                case DrawingTool.Rectangle:
                    g.DrawRectangle(pen, Math.Min(pressedX, mouseX), Math.Min(pressedY, mouseY), Math.Abs(mouseX - pressedX), Math.Abs(mouseY - pressedY));
                    break;
                case DrawingTool.Line:
                    g.DrawLine(pen, pressedX, pressedY, e.X, e.Y);
                    break;
                case DrawingTool.Polygon:
                    if (drawingPolygon) {
                        g.DrawLine(pen, PolygonX, PolygonY, e.X, e.Y);
                    }
                    else {
                        g.DrawLine(pen, pressedX, pressedY, e.X, e.Y);
                        drawingPolygon = true;
                    }
                    PolygonX = e.X;
                    PolygonY = e.Y;
                    break;
                case DrawingTool.ColorPicker:
                    if (mouseX < Pic.Width && mouseX > 0 && mouseY < Pic.Height && mouseY > 0) {
                        pen.Color = bitmap.GetPixel(mouseX, mouseY);
                        selectedTool = DrawingTool.Paintbrush;
                        drawBrushOutline = true;
                        wasDrawingBrushOutline = drawBrushOutline;
                    }
                    break;
                default:
                    break;
            }
        }

        private void Pic_MouseClick(object sender, EventArgs e) {
            switch (selectedTool) {
                case DrawingTool.Bucket:
                    FloodFill(bitmap, mouseX, mouseY, pen.Color);
                    Pic.Refresh();
                    break;
                default:
                    break;
            }
        }

        private void Pic_MouseEnter(object sender, EventArgs e) {
            if (wasDrawingBrushOutline) {
                drawBrushOutline = true;
            }
            else {
                drawBrushOutline = false;
            }
            Pic.Refresh();
        }

        private void Pic_MouseLeave(object sender, EventArgs e) {
            wasDrawingBrushOutline = drawBrushOutline;
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

        private void SaveButton_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.FileName = "Drawing";

            saveFileDialog.Filter = "PNG|*.png|JPEG|*.jpg";
            saveFileDialog.DefaultExt = "png";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                // Get selected image format
                ImageFormat imageFormat = saveFileDialog.FilterIndex switch {
                    1 => ImageFormat.Jpeg,
                    2 => ImageFormat.Png,
                    _ => ImageFormat.Png,
                };

                // Save image with selected format
                bitmap.Save(saveFileDialog.FileName, imageFormat);
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
            selectedTool = DrawingTool.Paintbrush;
            ColorBox.BackColor = pen.Color;
            SizeSelector.Value = (decimal)pen.Width;
            SizeSelector.Enabled = true;
            drawBrushOutline = true;
            wasDrawingBrushOutline = drawBrushOutline;
        }

        private void EraserButton_Click(object sender, EventArgs e) {
            selectedTool = DrawingTool.Eraser;
            ColorBox.BackColor = eraserPen.Color;
            SizeSelector.Value = (decimal)eraserPen.Width;
            SizeSelector.Enabled = true;
            drawBrushOutline = true;
            wasDrawingBrushOutline = drawBrushOutline;
        }

        private void BucketButton_Click(object sender, EventArgs e) {
            selectedTool = DrawingTool.Bucket;
            ColorBox.BackColor = pen.Color;
            SizeSelector.Value = (decimal)pen.Width;
            SizeSelector.Enabled = true;
            drawBrushOutline = false;
            wasDrawingBrushOutline = drawBrushOutline;
        }

        private void EllipseButton_Click(object sender, EventArgs e) {
            selectedTool = DrawingTool.Ellipse;
            ColorBox.BackColor = pen.Color;
            SizeSelector.Value = (decimal)pen.Width;
            SizeSelector.Enabled = true;
            drawBrushOutline = true;
            wasDrawingBrushOutline = drawBrushOutline;
        }

        private void RectangleButton_Click(object sender, EventArgs e) {
            selectedTool = DrawingTool.Rectangle;
            ColorBox.BackColor = pen.Color;
            SizeSelector.Value = (decimal)pen.Width;
            SizeSelector.Enabled = true;
            drawBrushOutline = true;
            wasDrawingBrushOutline = drawBrushOutline;
        }

        private void LineButton_Click(object sender, EventArgs e) {
            selectedTool = DrawingTool.Line;
            ColorBox.BackColor = pen.Color;
            SizeSelector.Value = (decimal)pen.Width;
            SizeSelector.Enabled = true;
            drawBrushOutline = true;
            wasDrawingBrushOutline = drawBrushOutline;
        }

        private void ColorPickerButton_Click(object sender, EventArgs e) {
            selectedTool = DrawingTool.ColorPicker;
            drawBrushOutline = false;
            wasDrawingBrushOutline = drawBrushOutline;
        }

        private void PencilButton_Click(object sender, EventArgs e) {
            selectedTool = DrawingTool.Pencil;
            ColorBox.BackColor = pen.Color;
            drawBrushOutline = false;
            wasDrawingBrushOutline = drawBrushOutline;
            SizeSelector.Value = (decimal)pencil.Width;
            SizeSelector.Enabled = false;
        }

        private void PolygonButton_Click(object sender, EventArgs e) {
            selectedTool = DrawingTool.Polygon;
            ColorBox.BackColor = pen.Color;
            drawBrushOutline = true;
            wasDrawingBrushOutline = drawBrushOutline;
            SizeSelector.Value = (decimal)pen.Width;
            SizeSelector.Enabled = true;
            drawingPolygon = false;
        }

        private void AirbrushButton_Click(object sender, EventArgs e) {
            selectedTool = DrawingTool.Airbrush;
            ColorBox.BackColor = pen.Color;
            drawBrushOutline = true;
            wasDrawingBrushOutline = drawBrushOutline;
            SizeSelector.Value = (decimal)pen.Width;
            SizeSelector.Enabled = true;
        }

        private void SizeSelector_KeyUp(object sender, KeyEventArgs e) {
            SizeSelector_ValueChanged(sender, e);
        }

        private void SizeSelector_ValueChanged(object sender, EventArgs e) {
            switch (selectedTool) {
                case DrawingTool.Eraser:
                    eraserPen.Width = (float)SizeSelector.Value;
                    break;
                case DrawingTool.Paintbrush:
                case DrawingTool.Ellipse:
                case DrawingTool.Rectangle:
                case DrawingTool.Line:
                case DrawingTool.Polygon:
                case DrawingTool.Airbrush:
                    pen.Width = (float)SizeSelector.Value;
                    break;
                default:
                    break;
            }
        }

        private void ColorBox_Click(object sender, EventArgs e) { //TODO: Set starting position
            if (selectedTool == DrawingTool.Eraser)
                return;

            ColorDialog cd = new();
            if (cd.ShowDialog() == DialogResult.OK) {
                pen.Color = cd.Color;
                pencil.Color = cd.Color;
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
