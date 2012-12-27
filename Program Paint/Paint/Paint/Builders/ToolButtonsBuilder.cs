using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paint.Operations;
using Paint.Operations.Draw;
using System.Windows.Forms;
using System.Drawing;

namespace Paint.Builders
{
    class ToolButtonsBuilder
    {
        OperationsOnToolButtons _operationsOnToolButtons;
        PaintForm _paintForm;

        public ToolButtonsBuilder(IDrawingFeatures drawingFeatures, PaintForm paintForm)
        {
            _paintForm = paintForm;

            _operationsOnToolButtons = new OperationsOnToolButtons(drawingFeatures); 
        }

        public Control[] CreateButtons()
        {
            Control[] buttons = new Control[20];
            
            buttons[0] = CreateToolButton("Circle");
            buttons[1] = CreateToolButton("Rectangle");
            buttons[2] = CreateToolButton("FilledCircle");
            buttons[3] = CreateToolButton("FilledRectangle");
            buttons[4] = CreateToolButton("Line");
            buttons[5] = CreateToolButton("Pencil");
            buttons[6] = CreateToolButton("Eraser");
            buttons[7] = CreateToolButton("FloodFill");

            buttons[8] = CreateTitleLabel("Line Style:");
            buttons[9] = CreateComboBox("WidthComboBox");
            buttons[10] = CreateToolButton("RoundLine");
            buttons[11] = CreateToolButton("SquareLine");

            buttons[12] = CreateTitleLabel("Rotating:");
            buttons[13] = CreateToolButton("RotateLeft90");
            buttons[14] = CreateToolButton("RotateRight90");
            buttons[15] = CreateToolButton("RotateRight180");
            buttons[16] = CreateToolButton("RotateRight270");
            buttons[17] = CreateToolButton("VerticalFlip");
            buttons[18] = CreateToolButton("HorizontalFlip");
            buttons[19] = CreateToolButton("HorizontalAndVerticalFlip");

            return buttons;
        }

        private Button CreateToolButton(string name)
        {
            Button toolButton = new Button();

            Bitmap icon = new Bitmap("Icons\\" + name + ".png");
            icon.MakeTransparent();

            toolButton.Image = new Bitmap(icon, new Size(22, 22));
            toolButton.Name = name;
            toolButton.Size = new Size(25, 25);

            toolButton.Click += _operationsOnToolButtons.ToolButton_Click;

            _paintForm.ToolTips.SetToolTip(toolButton, name);

            return toolButton;
        }

        private ComboBox CreateComboBox(string name)
        {
            ComboBox comboBox = new ComboBox();

            comboBox.Name = name;
            comboBox.Items.AddRange(new object[] {"1","5","20","40"});
            comboBox.Text = "Width";
            comboBox.Width = 60;

            comboBox.SelectedIndexChanged += _operationsOnToolButtons.WidthComboBox_Click;

            return comboBox;
        }

        private Label CreateTitleLabel(string text)
        {
            Label titleLabel = new Label();

            titleLabel.Text = text;
            titleLabel.Width = 60;
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;

            return titleLabel;
        }
    }
}
