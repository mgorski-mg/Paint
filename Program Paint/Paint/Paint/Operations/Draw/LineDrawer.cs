using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Paint.Operations.Draw
{
    class LineDrawer:ADrawable
    {
        private Point _startPoint;

        public LineDrawer(IDrawingFeatures drawingFeatures, Point startPoint)
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

            _drawingFeatures.Graphics.DrawLine(_drawingFeatures.Pencil, _startPoint, _currentPoint);

            _finalImage = (Bitmap)_drawingFeatures.PaintingArea.Image.Clone();
        }
    }
}
