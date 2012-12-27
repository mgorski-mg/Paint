using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paint.Operations.Draw;
using System.Windows.Forms;

namespace Paint.Operations.Menu
{
    class SaveCommand:IMenuCommand
    {
        private IDrawingFeatures _drawingFeatures;

        public SaveCommand(IDrawingFeatures drawingFeatures)
        {
            _drawingFeatures = drawingFeatures;
        }

        public void Execute()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "BMP (*.BMP)|*.BMP|JPEG (*.JPEG; *.JPG)|*.JPEG;*.JPG";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _drawingFeatures.PaintingArea.Image.Save(saveFileDialog.FileName);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not save the file");

                    Logger logger = new Logger();
                    logger.Log(e);
                }
            }
        }
    }
}
