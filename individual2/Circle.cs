using System;
using System.Collections.Generic;
using System.Text;

namespace individual2
{
    public class Circle : Shape
    {
        public double Radius { get; set; } 
        public Circle(SPoint[] points, double radius) : base(points)
        {
            this.Radius = radius;
        }
        public override double GetPerimetr()
        {
            return Math.Round(2 * Math.PI * Radius, 2);
        }
        public override double GetArea()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }
        public override string ToString()
        {
            return "\nFigure: Circle \n" + base.ToString();
        }
    }
}
