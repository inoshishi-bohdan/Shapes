using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace individual2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateFigureFromFile("figure_data1.txt"));
        }
        public static Shape CreateFigure(string parametrs)
        { 
            string figure = parametrs.Split(" ")[0];
            string[] figures = new string[] { "square", "rectangle", "rhombus", "triangle", "circle", "elips" };
            try
            {
                double[] coordinates = parametrs.Split(" ").Skip(1).Select(item => Double.Parse(item)).ToArray(); // тут просто координати 
                if (figure is String)
                {
                    if (Array.Exists(figures, item => item == figure))
                    {
                        switch (figure.ToLower())
                        {
                            case "square":
                                if (coordinates.Length == 8)
                                {
                                    return new Square(GetPoints(coordinates));
                                }
                                else
                                {
                                    Console.WriteLine("You provide not enough parameters");
                                    return null;
                                }
                            case "rectangle":
                                if (coordinates.Length == 8)
                                {
                                    return new Rectangle(GetPoints(coordinates));
                                }
                                else
                                {
                                    Console.WriteLine("You provide not enough parameters");
                                    return null;
                                }
                            case "rhombus":
                                if (coordinates.Length == 8)
                                {
                                    return new Rhombus(GetPoints(coordinates));
                                }
                                else
                                {
                                    Console.WriteLine("You provide not enough parameters");
                                    return null;
                                }
                            case "triangle":
                                if (coordinates.Length == 6)
                                {
                                    return new Triangle(GetPoints(coordinates));
                                }
                                else
                                {
                                    Console.WriteLine("You provide not enough parameters");
                                    return null;
                                }
                            case "circle":
                                if (coordinates.Length == 3)
                                {
                                    return new Circle(GetPoints(coordinates.Take(coordinates.Length - 1).ToArray()), coordinates.Last());
                                }
                                else
                                {
                                    Console.WriteLine("You provide not enough parameters");
                                    return null;
                                }
                            case "elips":
                                if (coordinates.Length == 8)
                                {
                                    return new Elips(GetPoints(coordinates.Take(6).ToArray()), /*left_focus: coordinates[2], right_focus: coordinates[3],*/ first_half_axis: coordinates[6], second_half_axis: coordinates[7]);
                                }
                                else
                                {
                                    Console.WriteLine("You provide not enough parameters");
                                    return null;
                                }
                            default:
                                return null;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No such type of figure");
                        return null;
                    }
                }
                else
                {
                    Console.WriteLine("You don't specify type of the figure");
                    return null;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("wrong tyoe of coordinates");// return information that specify wrong type of coordinates
                return null; 
            }
        }
        public static SPoint[] GetPoints(double[] coordinates) // запитати де варто розмістити цей метод
        { 
            List<SPoint> points = new List<SPoint>();
            for (int i = 0; i < coordinates.Length - 1; i += 2)
            {
                points.Add(new SPoint(x: coordinates[i], y: coordinates[i+1]));
            }
            return points.ToArray();
        }
        public static string[] ReadFigureParametersFromFile(string file_path) // all the next methods must be in win forms project
        {
            List<string> file_content_list = new List<string>(); 
            using (StreamReader reader = new StreamReader(file_path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    file_content_list.Add(line);
                }
            }
            return file_content_list.ToArray();
        }
        public static string CombineFiguresInforamtion(string[] file_content)
        {
            string[] figures_parameters = file_content.Skip(1).ToArray();
            StringBuilder figures_string_form = new StringBuilder();
            foreach (string line in figures_parameters)
            {
                Shape figure = CreateFigure(line);
                if (figure is null)
                {
                    figures_string_form.Append("\nObject is null so you can't get it's string representation \n");
                }
                else
                {
                    figures_string_form.Append(figure.ToString());
                }
            }
            return figures_string_form.ToString();  
        }
        public static string CreateFigureFromFile(string file_path)
        {
            string[] figure_parameters = ReadFigureParametersFromFile(file_path);
            return CombineFiguresInforamtion(figure_parameters);
        }
    }
}
