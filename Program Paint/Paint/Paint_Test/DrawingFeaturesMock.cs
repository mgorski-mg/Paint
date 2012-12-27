using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paint;
using System.Windows.Forms;
using Paint.Operations.Draw;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint_Test
{
    class DrawingFeaturesMock:IDrawingFeatures
    {
        public DrawingFeaturesMock()
        {
            InitializeContent();
        }

        public Pen Pencil
        {
            get;
            set;
        }

        public Graphics Graphics
        {
            get;
            set;
        }

        public PictureBox PaintingArea
        {
            get;
            set;
        }

        public DrawingState DrawingState
        {
            get;
            set;
        }

        public DrawingHistory DrawingHistory
        {
            get;
            set;
        }

        public PictureBox CurrentColorBox
        {
            get;
            set;
        }

        private void InitializeContent()
        {
            PaintingArea = new PictureBox();
            PaintingArea.Image = new Bitmap(1000, 1000);
            Graphics = Graphics.FromImage(PaintingArea.Image);
            Graphics.Clear(Color.White);

            Pencil = new Pen(Color.Black);
            Pencil.StartCap = LineCap.Round;
            Pencil.EndCap = LineCap.Round;

            DrawingHistory = new DrawingHistory();
            DrawingState = DrawingState.DrawPencil;

            CurrentColorBox = new PictureBox();
        }
    }
}
