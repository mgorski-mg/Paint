using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Paint.Operations.Draw;
using System.Drawing.Drawing2D;

namespace Paint.Operations
{
    class DrawingModule
    {
        private IDrawingFeatures _drawingFeatures;
        private Point _previousPoint;

        private ADrawable _currentDrawer = new NullDrawer();

        public DrawingModule(IDrawingFeatures drawingFeatures)
        {
            _drawingFeatures = drawingFeatures;
            _previousPoint = Point.Empty; 
        }

        public void Start()
        {
            AddEvents();
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !(_currentDrawer is FloodFill))
            {
                Point currentPoint = e.Location;

                _currentDrawer.SetPoints(_previousPoint, currentPoint);

                _currentDrawer.Draw();

                _drawingFeatures.PaintingArea.Refresh();
            }

            _previousPoint = e.Location;
        }

        private void LeftMouseButton_Down(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DrawableFactory drawableFactory = new DrawableFactory();

                Point currentPoint = e.Location;

                _currentDrawer = drawableFactory.CreateADrawableObject(_drawingFeatures, currentPoint);

                _currentDrawer.SetPoints(_previousPoint, currentPoint);

                _currentDrawer.Draw();

                _drawingFeatures.PaintingArea.Refresh();

                _drawingFeatures.DrawingHistory.History.Push(_currentDrawer);
            }

            _previousPoint = e.Location;
        }

        private void AddEvents()
        {
            _drawingFeatures.PaintingArea.MouseDown += LeftMouseButton_Down;
            _drawingFeatures.PaintingArea.MouseMove += MouseMove;
        }
    }
}
