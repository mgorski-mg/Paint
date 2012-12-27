using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paint.Operations.Draw;

namespace Paint.Operations.Menu
{
    class MenuCommandFactory
    {
        public IMenuCommand CreateIMenuCommnadObject(IDrawingFeatures drawingFeatures, string menuCommandName)
        {
            switch (menuCommandName)
            {
                case "New":
                    {
                        IMenuCommand menuCommnad = new NewCommand(drawingFeatures);

                        return menuCommnad;
                    }
                case "Open":
                    {
                        IMenuCommand menuCommnad = new OpenCommand(drawingFeatures);

                        return menuCommnad;
                    }
                case "Save":
                    {
                        IMenuCommand menuCommnad = new SaveCommand(drawingFeatures);

                        return menuCommnad;
                    }
                case "Undo":
                    {
                        IMenuCommand menuCommnad = new UndoCommand(drawingFeatures);

                        return menuCommnad;
                    }
                case "Redo":
                    {
                        IMenuCommand menuCommnad = new RedoCommand(drawingFeatures);

                        return menuCommnad;
                    }
                case "Resize":
                    {
                        IMenuCommand menuCommnad = new ResizePaintingAreaCommand(drawingFeatures);

                        return menuCommnad;
                    }
                default:
                    {
                        IMenuCommand menuCommnad = new NullMenuCommand();

                        Logger logger = new Logger();
                        logger.Log(new ArgumentException("MenuCommandFactory - MenuCommandName: " + menuCommandName));

                        return menuCommnad;
                    }
            }
        }
    }
}
