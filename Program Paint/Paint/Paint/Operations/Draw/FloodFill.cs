using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Paint.Operations.Draw
{
    class FloodFill:ADrawable
    {
        private Point _startPoint;

        public FloodFill(IDrawingFeatures drawingFeatures, Point startPoint)
        {
            _drawingFeatures = drawingFeatures;
            _startPoint = startPoint;

            _drawingFeatures.DrawingHistory.CanceledShares = new Stack<AUndoable>();
            _previousImage = (Bitmap)_drawingFeatures.PaintingArea.Image.Clone();
        }

        public override void Draw()
        {
            _drawingFeatures.PaintingArea.Image = (Bitmap)_previousImage.Clone();
            _drawingFeatures.Graphics = Graphics.FromImage(_drawingFeatures.PaintingArea.Image);

            Fill((Bitmap)_drawingFeatures.PaintingArea.Image, _currentPoint.X, _currentPoint.Y, _drawingFeatures.Pencil.Color);

            _finalImage = (Bitmap)_drawingFeatures.PaintingArea.Image.Clone();
        }

        private void Fill(Bitmap bitmap, int x, int y, Color color)
        {
            BitmapData data = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            int[] bits = new int[data.Stride / 4 * data.Height];
            Marshal.Copy(data.Scan0, bits, 0, bits.Length);

            LinkedList<Point> check = new LinkedList<Point>();
            int floodTo = color.ToArgb();
            int floodFrom = bits[x + y * data.Stride / 4];
            bits[x + y * data.Stride / 4] = floodTo;

            if (floodFrom != floodTo)
            {
                check.AddLast(new Point(x, y));

                while (check.Count > 0)
                {
                    Point currentPoint = check.First.Value;
                    check.RemoveFirst();

                    foreach (Point offsetPoint in new Point[] { new Point(0, -1), new Point(0, 1), new Point(-1, 0), new Point(1, 0) })
                    {
                        Point nextPoint = new Point(currentPoint.X + offsetPoint.X, currentPoint.Y + offsetPoint.Y);
                        if (nextPoint.X >= 0 && nextPoint.Y >= 0 && nextPoint.X < data.Width && nextPoint.Y < data.Height)
                        {
                            if (bits[nextPoint.X + nextPoint.Y * data.Stride / 4] == floodFrom)
                            {
                                check.AddLast(nextPoint);
                                bits[nextPoint.X + nextPoint.Y * data.Stride / 4] = floodTo;
                            }
                        }
                    }
                }
            }

            Marshal.Copy(bits, 0, data.Scan0, bits.Length);
            bitmap.UnlockBits(data);
        }
    }
}
