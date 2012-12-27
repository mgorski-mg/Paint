 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Paint.Operations.Draw
{
    class DrawableFactory
    {
        public ADrawable CreateADrawableObject(IDrawingFeatures drawingFeatures, Point startPoint)
        {
            switch (drawingFeatures.DrawingState)
            {
                case DrawingState.DrawCircle:
                    {
                        ADrawable draw = new CircleDrawer(drawingFeatures, startPoint);

                        return draw;
                    }
                case DrawingState.DrawRectangle:
                    {
                        ADrawable draw = new RectangleDrawer(drawingFeatures, startPoint);

                        return draw;
                    }
                case DrawingState.DrawFilledCircle:
                    {
                        ADrawable draw = new FillCircleDrawer(drawingFeatures, startPoint);

                        return draw;
                    }
                case DrawingState.DrawFilledRectangle:
                    {
                        ADrawable draw = new FillRectangleDrawer(drawingFeatures, startPoint);

                        return draw;
                    }
                case DrawingState.DrawLine:
                    {
                        ADrawable draw = new LineDrawer(drawingFeatures, startPoint);

                        return draw;
                    }
                case DrawingState.DrawPencil:
                    {
                        ADrawable draw = new PencilDrawer(drawingFeatures);

                        return draw;
                    }
                case DrawingState.FloodFill:
                    {
                        ADrawable draw = new FloodFill(drawingFeatures, startPoint);

                        return draw;
                    }
                default:
                    {
                        ADrawable draw = new NullDrawer();

                        Logger logger = new Logger();
                        logger.Log(new ArgumentException("DrawableFactory - Drawing State: "+drawingFeatures.DrawingState.ToString()));

                        return draw;
                    }
            }
        }
    }
}
