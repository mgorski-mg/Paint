using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paint.Operations.Draw;
using System.Windows.Forms;

namespace Paint.Operations.Menu
{
    class ResizePaintingAreaCommand:IMenuCommand
    {
        private IDrawingFeatures _drawingFeatures;

        public ResizePaintingAreaCommand(IDrawingFeatures drawingFeatures)
        {
            _drawingFeatures = drawingFeatures;
        }

        public void Execute() 
        {
            ResizeDialog resizeDialog = new ResizeDialog(_drawingFeatures);
            resizeDialog.ShowDialog();
        }
    }
}
