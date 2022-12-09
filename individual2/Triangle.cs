using System;
using System.Collections.Generic;
using System.Text;

namespace individual2
{
    public class Triangle : Polygon
    {
        public Triangle(SPoint[] points) : base(points)
        { }
        public override double GetArea()
        {
            double half_perimeter = GetPerimetr() / 2;
            double a = points[0].GetDistanceTo(points[1]);
            double b = points[1].GetDistanceTo(points[2]);
            double c = points[2].GetDistanceTo(points[0]);
            return Math.Round(Math.Sqrt(half_perimeter * (half_perimeter - a) * (half_perimeter - b) * (half_perimeter - c)), 2);
        }
        public override string ToString()
        {
            return "\nFigure: Triangle \n" + base.ToString();
        }
    }
}
