using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paint.Operations.Draw;
using System.Drawing.Drawing2D;

namespace Paint.Operations.Tools
{
    class LineShapeTool:ITool
    {
        private IDrawingFeatures _drawingFeatures;
        private LineCap _lineCapStyle;

        public LineShapeTool(IDrawingFeatures drawingFeatures, LineCap lineCapStyle)
        {
            _drawingFeatures = drawingFeatures;
            _lineCapStyle = lineCapStyle;
        }

        public void Execute()
        {
            _drawingFeatures.Pencil.StartCap = _lineCapStyle;
            _drawingFeatures.Pencil.EndCap = _lineCapStyle;
        }
    }
}
