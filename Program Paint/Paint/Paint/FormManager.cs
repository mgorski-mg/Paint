using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Paint.Operations;
using System.Windows.Forms;
using Paint.Builders;
using System.Drawing;
using Paint.Operations.Draw;

namespace Paint
{
    class FormManager
    {
        private PaintForm _paintForm;
        private IDrawingFeatures _drawingFeatures;

        public FormManager(PaintForm paintForm)
        {
            _paintForm = paintForm;

            InitializeDrawingFeatures();
        }

        public void Start()
        {
            CreateColorButtons();
            CreateMenuButtons();
            CreateToolButtons();

            StartDrawingModule();  
        }

        private void CreateColorButtons()
        {
            ColorButtonsBuilder colorButtonsBuilder = new ColorButtonsBuilder(_drawingFeatures);

            Control[] colorButtons = colorButtonsBuilder.CreateButtons();

            _paintForm.ColorsPanel.Controls.AddRange(colorButtons);
        }

        private void CreateMenuButtons()
        {
            MenuButtonBuilder menuButtonBuilder = new MenuButtonBuilder(_drawingFeatures);

            ToolStripItem[] menuButtons = menuButtonBuilder.CreateButtons();

            _paintForm.MenuPanel.Items.AddRange(menuButtons);
        }

        private void CreateToolButtons()
        {
            ToolButtonsBuilder toolButtonBuilder = new ToolButtonsBuilder(_drawingFeatures, _paintForm);

            Control[] toolButtons = toolButtonBuilder.CreateButtons();

            _paintForm.ToolsPanel.Controls.AddRange(toolButtons);
        }

        private void StartDrawingModule()
        {
            DrawingModule drawingModule = new DrawingModule(_drawingFeatures);

            drawingModule.Start();
        }

        private void InitializeDrawingFeatures()
        {
            _drawingFeatures = new DrawingFeatures(_paintForm);
        }
    }
}
