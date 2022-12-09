using System;
using System.Collections.Generic;
using System.Text;

namespace individual2
{
    public class Rectangle : Polygon
    {
        public Rectangle(SPoint[] points) : base(points)
        { }
        public override double GetArea()
        {
            return Math.Round(points[0].GetDistanceTo(points[1]) * points[1].GetDistanceTo(points[2]), 2);
        }
        public override string ToString()
        {
            return "\nFigure: Rectangle \n" + base.ToString();
        }
    }
}
