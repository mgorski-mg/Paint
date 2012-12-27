using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Paint.Operations.Draw;

namespace Paint
{
    public class DrawingFeatures:IDrawingFeatures
    {
        public DrawingFeatures(PaintForm paintForm)
        {
            InitializeContent(paintForm);
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

        private void InitializeContent(PaintForm paintForm)
        {
            PaintingArea = paintForm.PaintingArea;
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
