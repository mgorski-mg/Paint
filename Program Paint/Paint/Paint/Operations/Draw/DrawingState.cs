using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Paint.Operations.Draw
{
    public enum DrawingState
    {
        DrawLine,
        DrawCircle,
        DrawRectangle,
        DrawFilledCircle,
        DrawFilledRectangle,
        DrawPencil,
        FloodFill
    }
}
