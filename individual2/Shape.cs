using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace individual2
{
    public abstract class Shape
    {
        protected SPoint[] points;
        protected Shape(SPoint[] points)
        {
            this.points = points;
        }
        public abstract double GetPerimetr();
        public abstract double GetArea();
        public override string ToString()
        {
            return $"Points: {String.Join(' ',points.Select(item => $"({item.X} ; {item.Y})"))} \nPerimeter: {GetPerimetr()} \nArea: {GetArea()} \n";
        }
    }
}
