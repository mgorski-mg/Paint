using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paint.Operations.Draw;
using System.Windows.Forms;
using Paint.Operations.Tools;

namespace Paint.Operations
{
    class OperationsOnToolButtons
    {
        IDrawingFeatures _drawingFeatures;

        public OperationsOnToolButtons(IDrawingFeatures drawingFeatures)
        {
            _drawingFeatures = drawingFeatures;
        }

        public void ToolButton_Click(object sender, EventArgs e)
        {
            string name = (sender as Button).Name;

            ToolFactory toolFactory = new ToolFactory();

            ITool tool = toolFactory.CreateIToolObject(_drawingFeatures, name);

            tool.Execute();

            if (tool is AUndoable)
            {
                _drawingFeatures.DrawingHistory.History.Push((AUndoable)tool);
            }
        }

        public void WidthComboBox_Click(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            int selectedWidth = int.Parse(comboBox.SelectedItem.ToString());

            _drawingFeatures.Pencil.Width = selectedWidth;
        }
    }
}
