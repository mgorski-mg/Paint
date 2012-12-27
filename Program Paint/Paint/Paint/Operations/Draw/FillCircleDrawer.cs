using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Paint.Operations.Draw
{
    class FillCircleDrawer:ADrawable
    {
        private Point _startPoint;

        public FillCircleDrawer(IDrawingFeatures drawingFeatures, Point startPoint)
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

            int ellipseHeight = _currentPoint.Y - _startPoint.Y;
            int ellipseWidth = _currentPoint.X - _startPoint.X;

            _drawingFeatures.Graphics.FillEllipse(_drawingFeatures.Pencil.Brush, _startPoint.X, _startPoint.Y, ellipseWidth, ellipseHeight);

            _finalImage = (Bitmap)_drawingFeatures.PaintingArea.Image.Clone();
        }
    }
}
