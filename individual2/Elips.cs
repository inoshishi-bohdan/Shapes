using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace individual2
{
    public class Elips : Shape
    {
        public Elips(SPoint[] points, double first_half_axis, double second_half_axis) : base(points)
        { 
            this.Left_Focus = points[1];
            this.Right_Focus = points[2];
            this.First_Half_Axis = first_half_axis;
            this.Second_Half_Axis = second_half_axis;
        }
        public SPoint Left_Focus { get; set; }
        public SPoint Right_Focus { get; set; }
        public double First_Half_Axis { get; set; }
        public double Second_Half_Axis { get; set; }

        public override double GetArea()
        {
            return Math.Round(Math.PI * First_Half_Axis * Second_Half_Axis, 2);
        }
        public override double GetPerimetr()
        {
            return Math.Round(4 * (Math.PI * First_Half_Axis * Second_Half_Axis + Math.Pow((First_Half_Axis - Second_Half_Axis),2)) / (First_Half_Axis + Second_Half_Axis), 2); 
        }
        public override string ToString()
        {
            return $"\nFigure: Elips \nPoints: {String.Join(' ', points.Select(item => $"({item.X} ; {item.Y})"))}\nLeft-Focus: ({points[1].X}; {points[1].Y})\nRight-Focus: ({points[2].X}; {points[2].Y}) \nPerimeter: {GetPerimetr()} \nArea: {GetArea()} \n";
        }
    }
}
