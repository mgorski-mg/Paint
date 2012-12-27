using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paint.Operations.Draw;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.Operations.Tools
{
    class EraserTool:ITool
    {
        private IDrawingFeatures _drawingFeatures;

        public EraserTool(IDrawingFeatures drawingFeatures)
        {
            _drawingFeatures = drawingFeatures;
        }

        public void Execute()
        {
            _drawingFeatures.DrawingState = DrawingState.DrawPencil;

            Color color = Color.White;

            _drawingFeatures.CurrentColorBox.BackColor = color;

            _drawingFeatures.Pencil.Color = color;
            _drawingFeatures.Pencil.StartCap = LineCap.Round;
            _drawingFeatures.Pencil.EndCap = LineCap.Round;
        }
    }
}
