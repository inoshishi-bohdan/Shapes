using System;
using System.Collections.Generic;
using System.Text;

namespace individual2
{
    public class SPoint
    {
        public double X { get; set; }
        public double Y { get; set; }
        public SPoint(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double GetDistanceTo(SPoint end)
        {
            return Math.Sqrt(Math.Pow((end.X - X), 2) + Math.Pow((end.Y - Y), 2));
        }
    }
}
