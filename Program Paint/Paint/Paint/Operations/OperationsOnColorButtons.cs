using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Paint.Operations.Draw;

namespace Paint.Operations
{
    class OperationsOnColorButtons
    {
        private IDrawingFeatures _drawingFeatures;

        public OperationsOnColorButtons(IDrawingFeatures drawingFeatures)
        {
            _drawingFeatures = drawingFeatures;
        }

        public void ColorButton_Click(object sender, EventArgs e)
        {
            Color color = (sender as PictureBox).BackColor;

            _drawingFeatures.Pencil.Color = color;

            _drawingFeatures.CurrentColorBox.BackColor = color;
        }

        public void OtherColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                _drawingFeatures.Pencil.Color = colorDialog.Color;

                _drawingFeatures.CurrentColorBox.BackColor = colorDialog.Color;
            }
        }
    }
}
