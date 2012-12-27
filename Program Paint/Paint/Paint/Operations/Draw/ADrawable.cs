using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Paint.Operations.Draw
{
    public abstract class ADrawable:AUndoable
    {
        protected Point _currentPoint;
        protected Point _previousPoint;

        public abstract void Draw();

        public void SetPoints(Point previousPoint, Point currentPoint)
        {
            _previousPoint = previousPoint;
            _currentPoint = currentPoint;
        }
    }
}
