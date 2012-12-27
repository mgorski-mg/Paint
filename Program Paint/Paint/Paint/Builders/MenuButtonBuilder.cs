using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paint.Operations.Draw;
using System.Windows.Forms;
using System.Drawing;
using Paint.Operations;
using System.ComponentModel;

namespace Paint.Builders
{
    class MenuButtonBuilder
    {
        private OperationsOnMenuButtons _operationsOnMenuButtons;

        public MenuButtonBuilder(IDrawingFeatures drawingFeatures)
        {
            _operationsOnMenuButtons = new OperationsOnMenuButtons(drawingFeatures);
        }

        public ToolStripItem[] CreateButtons()
        {
            ToolStripItem[] menuButtons = new ToolStripItem[7];

            menuButtons[0] = CreateButton("New");
            menuButtons[1] = CreateButton("Open");
            menuButtons[2] = CreateButton("Save");
            menuButtons[3] = new ToolStripSeparator();
            menuButtons[4] = CreateButton("Undo");
            menuButtons[5] = CreateButton("Redo");
            menuButtons[6] = CreateButton("Resize");

            return menuButtons;
        }

        private ToolStripItem CreateButton(string name)
        {
            ToolStripItem menuButton = new ToolStripButton();

            menuButton.Image = Bitmap.FromFile("Icons\\"+name+".png");
            menuButton.Size = new System.Drawing.Size(23, 22);
            menuButton.Name = name;
            menuButton.ToolTipText = name;

            menuButton.Click += _operationsOnMenuButtons.MenuButton_Click;

            return menuButton;
        }
    }
}
