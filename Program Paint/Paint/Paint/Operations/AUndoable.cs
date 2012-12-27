using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Paint.Operations.Draw;

namespace Paint.Operations
{
    public abstract class AUndoable
    {
        protected IDrawingFeatures _drawingFeatures;

        protected Bitmap _previousImage;
        protected Bitmap _finalImage;

        public void Undo()
        {
            _drawingFeatures.PaintingArea.Image = (Bitmap)_previousImage.Clone();

            _drawingFeatures.Graphics = Graphics.FromImage(_drawingFeatures.PaintingArea.Image);
        }

        public void Redo()
        {
            _drawingFeatures.PaintingArea.Image = (Bitmap)_finalImage.Clone();

            _drawingFeatures.Graphics = Graphics.FromImage(_drawingFeatures.PaintingArea.Image);
        }
    }
}
