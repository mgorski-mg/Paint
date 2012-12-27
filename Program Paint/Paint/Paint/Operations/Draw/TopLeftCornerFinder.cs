using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Paint.Operations.Draw
{
    class TopLeftCornerFinder
    {
        public Point FindTopLeftCorner(Point startPoint, Point currentPoint)
        {
            Point topLeftCorner = new Point();

            topLeftCorner.X = FindCoordinate(startPoint.X, currentPoint.X);

            topLeftCorner.Y = FindCoordinate(startPoint.Y, currentPoint.Y);

            return topLeftCorner;
        }

        private int FindCoordinate(int startPointCoordinate, int currentPointcoordinate)
        {
            int topLeftCornerCoordinate;

            if (currentPointcoordinate - startPointCoordinate >= 0)
            {
                topLeftCornerCoordinate = startPointCoordinate;
            }
            else
            {
                topLeftCornerCoordinate = currentPointcoordinate;
            }

            return topLeftCornerCoordinate;
        }
    }
}
