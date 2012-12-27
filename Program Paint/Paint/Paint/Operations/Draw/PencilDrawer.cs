using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace Paint.Operations.Draw
{
    class PencilDrawer:ADrawable
    {
        public PencilDrawer(IDrawingFeatures drawingFeatures)
        {
            _drawingFeatures = drawingFeatures;

            _drawingFeatures.DrawingHistory.CanceledShares = new Stack<AUndoable>();
            _previousImage = (Bitmap)_drawingFeatures.PaintingArea.Image.Clone();
        }

        public override void Draw()
        {
            _drawingFeatures.Graphics.DrawLine(_drawingFeatures.Pencil, _previousPoint, _currentPoint);

            _finalImage = (Bitmap)_drawingFeatures.PaintingArea.Image.Clone();
        }
    }
}
