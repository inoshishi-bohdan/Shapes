using System;
using System.Collections.Generic;
using System.Text;

namespace individual2
{
    public abstract class Polygon : Shape
    {
        public Polygon(SPoint [] points) : base(points)
        { }
        public override double GetPerimetr()
        {
            double perimetr = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                perimetr += points[i].GetDistanceTo(points[i + 1]);
                if (i == points.Length - 2)
                {
                    perimetr += points[0].GetDistanceTo(points[points.Length - 1]);
                }
            }
            return Math.Round(perimetr, 2);
        }
        public abstract override double GetArea();
    }
}
