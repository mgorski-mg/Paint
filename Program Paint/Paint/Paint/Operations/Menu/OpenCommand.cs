using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paint.Operations.Draw;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace Paint.Operations.Menu
{
    class OpenCommand:IMenuCommand
    {
        private IDrawingFeatures _drawingFeatures;

        public OpenCommand(IDrawingFeatures drawingFeatures)
        {
            _drawingFeatures = drawingFeatures;
        }

        public void Execute()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "BMP (*.BMP)|*.BMP|JPEG (*.JPEG; *.JPG)|*.JPEG;*.JPG|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap openedBitmap = (Bitmap)Bitmap.FromFile(openFileDialog.FileName);

                    _drawingFeatures.PaintingArea.Image = ConvertIndexedBitmapToNonIndexed(openedBitmap);

                    _drawingFeatures.Graphics = Graphics.FromImage(_drawingFeatures.PaintingArea.Image);
                }
                catch(Exception e)
                {
                    _drawingFeatures.PaintingArea.Image = new Bitmap(1000, 1000);
                    _drawingFeatures.Graphics = Graphics.FromImage(_drawingFeatures.PaintingArea.Image);

                    MessageBox.Show("Could not open the file");
                    
                    Logger logger = new Logger();
                    logger.Log(e);
                }
                finally
                {
                    _drawingFeatures.DrawingHistory = new DrawingHistory();
                }
            }
        }

        private Bitmap ConvertIndexedBitmapToNonIndexed(Bitmap bitmap)
        {
            bool imagesPixelsIsIndexed = (bitmap.PixelFormat == PixelFormat.Indexed || bitmap.PixelFormat == PixelFormat.Format1bppIndexed || bitmap.PixelFormat == PixelFormat.Format4bppIndexed || bitmap.PixelFormat == PixelFormat.Format8bppIndexed);
            
            if(imagesPixelsIsIndexed) 
            {
                bitmap = bitmap.Clone(new Rectangle(0, 0, bitmap.Width, bitmap.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            }

            return bitmap;
        }
    }
}
