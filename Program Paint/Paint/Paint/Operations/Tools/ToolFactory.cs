using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paint.Operations.Draw;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Paint.Operations.Tools
{
    class ToolFactory
    {
        public ITool CreateIToolObject(IDrawingFeatures drawingFeatures, string toolName)
        {
            switch (toolName)
            {
                case "RotateLeft90":
                    {
                        ITool tool = new RotateTool(drawingFeatures, RotateFlipType.Rotate90FlipXY);

                        return tool;
                    }
                case "RotateRight90":
                    {
                        ITool tool = new RotateTool(drawingFeatures, RotateFlipType.Rotate90FlipNone);

                        return tool;
                    }
                case "RotateRight180":
                    {
                        ITool tool = new RotateTool(drawingFeatures, RotateFlipType.Rotate180FlipNone);

                        return tool;
                    }
                case "RotateRight270":
                    {
                        ITool tool = new RotateTool(drawingFeatures, RotateFlipType.Rotate270FlipNone);

                        return tool;
                    }
                case "VerticalFlip":
                    {
                        ITool tool = new RotateTool(drawingFeatures, RotateFlipType.RotateNoneFlipY);

                        return tool;
                    }
                case "HorizontalFlip":
                    {
                        ITool tool = new RotateTool(drawingFeatures, RotateFlipType.RotateNoneFlipX);

                        return tool;
                    }
                case "HorizontalAndVerticalFlip":
                    {
                        ITool tool = new RotateTool(drawingFeatures, RotateFlipType.RotateNoneFlipXY);

                        return tool;
                    }
                case "RoundLine":
                    {
                        ITool tool = new LineShapeTool(drawingFeatures, LineCap.Round);

                        return tool;
                    }
                case "SquareLine":
                    {
                        ITool tool = new LineShapeTool(drawingFeatures, LineCap.Square);

                        return tool;
                    }
                case "Circle":
                    {
                        ITool tool = new DrawingStyleTool(drawingFeatures,DrawingState.DrawCircle);

                        return tool;
                    }
                case "Rectangle":
                    {
                        ITool tool = new DrawingStyleTool(drawingFeatures, DrawingState.DrawRectangle);

                        return tool;
                    }
                case "FilledCircle":
                    {
                        ITool tool = new DrawingStyleTool(drawingFeatures, DrawingState.DrawFilledCircle);

                        return tool;
                    }
                case "FilledRectangle":
                    {
                        ITool tool = new DrawingStyleTool(drawingFeatures, DrawingState.DrawFilledRectangle);

                        return tool;
                    }
                case "Line":
                    {
                        ITool tool = new DrawingStyleTool(drawingFeatures, DrawingState.DrawLine);

                        return tool;
                    }
                case "Pencil":
                    {
                        ITool tool = new DrawingStyleTool(drawingFeatures, DrawingState.DrawPencil);

                        return tool;
                    }
                case "Eraser":
                    {
                        ITool tool = new EraserTool(drawingFeatures);

                        return tool;
                    }
                case "FloodFill":
                    {
                        ITool tool = new DrawingStyleTool(drawingFeatures, DrawingState.FloodFill);

                        return tool;
                    }
                default:
                    {
                        ITool tool = new NullTool();

                        Logger logger = new Logger();
                        logger.Log(new ArgumentException("ToolFactory - ToolName: " + toolName));

                        return tool;
                    }
            }
        }
    }
}
