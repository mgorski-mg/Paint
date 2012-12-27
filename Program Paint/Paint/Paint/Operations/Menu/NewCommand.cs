using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paint.Operations.Draw;
using System.Drawing;

namespace Paint.Operations.Menu
{
    class NewCommand:IMenuCommand
    {
        private IDrawingFeatures _drawingFeatures;

        public NewCommand(IDrawingFeatures drawingFeatures)
        {
            _drawingFeatures = drawingFeatures;
        }

        public void Execute() 
        {
            _drawingFeatures.Graphics.Clear(Color.White);

            _drawingFeatures.DrawingHistory = new DrawingHistory();
        }
    }
}
