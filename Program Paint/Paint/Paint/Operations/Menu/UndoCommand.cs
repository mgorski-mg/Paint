using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paint.Operations.Draw;

namespace Paint.Operations.Menu
{
    class UndoCommand:IMenuCommand
    {
        private IDrawingFeatures _drawingFeatures;

        public UndoCommand(IDrawingFeatures drawingFeatures)
        {
            _drawingFeatures = drawingFeatures;
        }

        public void Execute()
        {
            if (_drawingFeatures.DrawingHistory.History.Count > 0)
            {
                AUndoable drawer = _drawingFeatures.DrawingHistory.History.Pop();

                _drawingFeatures.DrawingHistory.CanceledShares.Push(drawer);

                drawer.Undo();
            }
        }
    }
}
