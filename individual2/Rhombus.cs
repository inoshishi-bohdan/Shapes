using System;
using System.Collections.Generic;
using System.Text;

namespace individual2
{
    public class Rhombus : Polygon
    {
        public Rhombus(SPoint[] points) : base(points)
        { }
        public override double GetArea()
        {
            double first_diagonal = points[0].GetDistanceTo(points[2]);
            double second_diagonal = points[1].GetDistanceTo(points[3]);
            return Math.Round(first_diagonal * second_diagonal * 0.5, 2);
        }
        public override string ToString()
        {
            return "\nFigure: Rhombus \n" + base.ToString();
        }
    }
}
