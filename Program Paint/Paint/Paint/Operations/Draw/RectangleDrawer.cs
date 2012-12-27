using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Paint.Operations.Draw
{
    class RectangleDrawer:ADrawable
    {
        private Point _startPoint;

        public RectangleDrawer(IDrawingFeatures drawingFeatures, Point startPoint)
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

            int rectangleHeight = Math.Abs(_currentPoint.Y - _startPoint.Y);
            int rectangleWidth = Math.Abs(_currentPoint.X - _startPoint.X);

            TopLeftCornerFinder topLeftCornerFinder = new TopLeftCornerFinder();

            Point topLeftCorner = topLeftCornerFinder.FindTopLeftCorner(_startPoint, _currentPoint);

            _drawingFeatures.Graphics.DrawRectangle(_drawingFeatures.Pencil,topLeftCorner.X,topLeftCorner.Y, rectangleWidth, rectangleHeight);

            _finalImage = (Bitmap)_drawingFeatures.PaintingArea.Image.Clone();
        }
    }
}
