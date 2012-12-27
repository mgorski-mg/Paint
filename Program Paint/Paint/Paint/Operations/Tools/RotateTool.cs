using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paint.Operations.Draw;
using System.Drawing;

namespace Paint.Operations.Tools
{
    class RotateTool:AUndoable,ITool
    {
        private RotateFlipType _rotateType;

        public RotateTool(IDrawingFeatures drawingFeatures, RotateFlipType rotateType)
        {
            _drawingFeatures = drawingFeatures;
            _rotateType = rotateType;

            _drawingFeatures.DrawingHistory.CanceledShares = new Stack<AUndoable>();
            _previousImage = (Bitmap)_drawingFeatures.PaintingArea.Image.Clone();
        }

        public void Execute()
        {
            _drawingFeatures.PaintingArea.Image.RotateFlip(_rotateType);

            _drawingFeatures.PaintingArea.Size = _drawingFeatures.PaintingArea.Image.Size;

            _drawingFeatures.PaintingArea.Refresh();

            _finalImage = (Bitmap)_drawingFeatures.PaintingArea.Image.Clone();
        }
    }
}
