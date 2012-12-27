using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paint.Operations.Draw;

namespace Paint.Operations.Menu
{
    class RedoCommand:IMenuCommand
    {
        private IDrawingFeatures _drawingFeatures;

        public RedoCommand(IDrawingFeatures drawingFeatures)
        {
            _drawingFeatures = drawingFeatures;
        }

        public void Execute()
        {
            if (_drawingFeatures.DrawingHistory.CanceledShares.Count > 0)
            {
                AUndoable drawer = _drawingFeatures.DrawingHistory.CanceledShares.Pop();

                _drawingFeatures.DrawingHistory.History.Push(drawer);

                drawer.Redo();
            }
        }
    }
}
