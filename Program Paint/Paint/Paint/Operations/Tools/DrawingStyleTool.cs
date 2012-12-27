using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paint.Operations.Draw;

namespace Paint.Operations.Tools
{
    class DrawingStyleTool:ITool
    {
        private IDrawingFeatures _drawingFeatures;
        private DrawingState _drawingState;

        public DrawingStyleTool(IDrawingFeatures drawingFeatures, DrawingState drawingState)
        {
            _drawingFeatures = drawingFeatures;
            _drawingState = drawingState;
        }

        public void Execute()
        {
            _drawingFeatures.DrawingState = _drawingState;
        }
    }
}
