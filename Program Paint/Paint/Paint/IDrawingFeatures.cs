using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Paint.Operations.Draw;

namespace Paint
{
    public interface IDrawingFeatures
    {
        Pen Pencil
        {
            get;
            set;
        }

        Graphics Graphics
        {
            get;
            set;
        }

        PictureBox PaintingArea
        {
            get;
            set;
        }

        DrawingState DrawingState
        {
            get;
            set;
        }

        DrawingHistory DrawingHistory
        {
            get;
            set;
        }

        PictureBox CurrentColorBox
        {
            get;
            set;
        }
    }
}
