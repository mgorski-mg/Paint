using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Paint.Operations;
using Paint.Operations.Draw;

namespace Paint.Builders
{
    class ColorButtonsBuilder
    {
        IDrawingFeatures _drawingFeatures;
        OperationsOnColorButtons _operationsOnColorButtons;

        public ColorButtonsBuilder(IDrawingFeatures drawingFeatures)
        {
            _drawingFeatures = drawingFeatures;
            _operationsOnColorButtons = new OperationsOnColorButtons(_drawingFeatures);
        }

        public Control[] CreateButtons()
        {
            Control[] buttons = new Control[24];

            buttons[1] = CreateCurrentColorPanel();

            buttons[2] = CreateColorPictureBox(Color.White);
            buttons[3] = CreateColorPictureBox(Color.Black);
            buttons[4] = CreateColorPictureBox(Color.Blue);
            buttons[5] = CreateColorPictureBox(Color.LightBlue);
            buttons[6] = CreateColorPictureBox(Color.Gray);
            buttons[7] = CreateColorPictureBox(Color.Green);
            buttons[8] = CreateColorPictureBox(Color.HotPink);
            buttons[9] = CreateColorPictureBox(Color.Brown);
            buttons[10] = CreateColorPictureBox(Color.Olive);
            buttons[11] = CreateColorPictureBox(Color.Orange);
            buttons[12] = CreateColorPictureBox(Color.Red);
            buttons[13] = CreateColorPictureBox(Color.Violet);
            buttons[14] = CreateColorPictureBox(Color.Yellow);
            buttons[15] = CreateColorPictureBox(Color.YellowGreen);
            buttons[16] = CreateColorPictureBox(Color.Turquoise);
            buttons[17] = CreateColorPictureBox(Color.BlanchedAlmond);
            buttons[18] = CreateColorPictureBox(Color.Salmon);
            buttons[19] = CreateColorPictureBox(Color.AliceBlue);
            buttons[20] = CreateColorPictureBox(Color.Azure);
            buttons[21] = CreateColorPictureBox(Color.Beige);
            buttons[22] = CreateColorPictureBox(Color.Chocolate);

            buttons[23] = CreateOtherColorsButton();

            return buttons;
        }

        private PictureBox CreateColorPictureBox(Color color)
        {
            PictureBox colorButton = new PictureBox();

            colorButton.BackColor = color;
            colorButton.Size = new Size(16, 16);
            colorButton.BorderStyle = BorderStyle.FixedSingle;

            colorButton.Click += _operationsOnColorButtons.ColorButton_Click;

            return colorButton;
        }

        private Label CreateOtherColorsButton()
        {
            Label otherColorsButton = new Label();

            otherColorsButton.Size = new Size(60, 50);
            otherColorsButton.Text = "Edit Colors";
            otherColorsButton.TextAlign = ContentAlignment.MiddleCenter;
            otherColorsButton.BorderStyle = BorderStyle.FixedSingle;

            otherColorsButton.Click += _operationsOnColorButtons.OtherColorButton_Click;

            return otherColorsButton;
        }

        private Panel CreateCurrentColorPanel()
        {
            Panel currentColorPanel = new Panel();

            currentColorPanel.Size = new Size(60, 50);
            currentColorPanel.BorderStyle = BorderStyle.FixedSingle;
            currentColorPanel.BackColor = Color.White;

            Color currentColor = _drawingFeatures.Pencil.Color;

            PictureBox currentColorBox = CreateColorPictureBox(currentColor);

            Point currentColorBoxLocation = new Point(currentColorPanel.Location.X + (currentColorPanel.Width/2 - currentColorBox.Width/2), currentColorPanel.Location.Y + (currentColorPanel.Height/2 - currentColorBox.Height/2));

            currentColorBox.Location = currentColorBoxLocation;

            currentColorPanel.Controls.Add(currentColorBox);

            _drawingFeatures.CurrentColorBox = currentColorBox;

            return currentColorPanel;
        }
    }
}
