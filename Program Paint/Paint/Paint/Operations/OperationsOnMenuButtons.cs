using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Paint.Operations.Draw;
using Paint.Operations.Menu;

namespace Paint.Operations
{
    class OperationsOnMenuButtons
    {
        private IDrawingFeatures _drawingFeatures;

        public OperationsOnMenuButtons(IDrawingFeatures drawingFeatures)
        {
            _drawingFeatures = drawingFeatures;
        }

        public void MenuButton_Click(object sender, EventArgs e)
        {
            string name = (sender as ToolStripButton).Name;

            MenuCommandFactory menuCommandFactory = new MenuCommandFactory();

            IMenuCommand menuCommand = menuCommandFactory.CreateIMenuCommnadObject(_drawingFeatures, name);

            menuCommand.Execute();

            _drawingFeatures.PaintingArea.Refresh();
        }
    }
}
