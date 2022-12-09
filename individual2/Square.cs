using System;
using System.Collections.Generic;
using System.Text;

namespace individual2
{
    public class Square : Polygon
    {
        public Square(SPoint[] points) : base(points)
        { }
        public override double GetArea()
        {
            return Math.Round(Math.Pow(points[0].GetDistanceTo(points[1]), 2), 2);
        }
        public override string ToString()
        {
            return "\nFigure: Square \n" + base.ToString();
        }
    }
}
