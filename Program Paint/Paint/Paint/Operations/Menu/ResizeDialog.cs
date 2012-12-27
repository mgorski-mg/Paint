using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Paint.Operations.Menu
{
    public partial class ResizeDialog : Form
    {
        IDrawingFeatures _drawingFeatures;

        public ResizeDialog(IDrawingFeatures drawingFeatures)
        {
            _drawingFeatures = drawingFeatures;

            InitializeComponent();  
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Bitmap currentImage = (Bitmap)_drawingFeatures.PaintingArea.Image.Clone();

            _drawingFeatures.PaintingArea.Image = new Bitmap(int.Parse(widthTextBox.Text), int.Parse(heightTextBox.Text));
            _drawingFeatures.Graphics = Graphics.FromImage(_drawingFeatures.PaintingArea.Image);

            _drawingFeatures.Graphics.DrawImage(currentImage, 0, 0, int.Parse(widthTextBox.Text),int.Parse(heightTextBox.Text));

            this.Dispose();
            this.Close();
        }
    }
}
