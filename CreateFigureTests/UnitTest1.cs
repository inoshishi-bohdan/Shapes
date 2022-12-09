using NUnit.Framework;
using individual2;
using System.Linq;

namespace CreateFigureTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new double[8] {-1, 1, 2, 1, 2, -1, -1, -1}, 10d)]
        [TestCase(new double[8] {4, 10, 8, 10, 8, 3, 4, 3}, 22d)]
        [TestCase(new double[8] {-10, 10, 1, 10, 1, 3, -10, 3}, 36d)]
        [TestCase(new double[8] {-1, 14, 0, 14, 0, 13, -1, 13}, 4d)]
        public void GetRightPerimeterRectangle(double[] coordinates, double expected_perimeter)
        {
            Rectangle testing_rectangle = new Rectangle(Program.GetPoints(coordinates));
            double actual_perimeter = testing_rectangle.GetPerimetr();
            Assert.That(expected_perimeter, Is.EqualTo(actual_perimeter));
        }
        [TestCase(new double[8] {-6, 10, 1, 10, 1, 3, -6, 3}, 28d)]
        [TestCase(new double[8] {4, 10, 8, 10, 8, 6, 4, 6}, 16d)]
        [TestCase(new double[8] {-1, 1, 1, 1, 1, -1, -1, -1}, 8d)]
        [TestCase(new double[8] { -1, 14, 0, 14, 0, 13, -1, 13 }, 4d)]
        public void GetRightPerimeterSquare(double[] coordinates, double expected_perimeter)
        {
            Square testing_square = new Square(Program.GetPoints(coordinates));
            double actual_perimeter = testing_square.GetPerimetr();
            Assert.That(expected_perimeter, Is.EqualTo(actual_perimeter));
        }
        [TestCase(new double[] { -6, 8, 1, 3, -6, 3 }, 20.60d)]
        [TestCase(new double[] {6, 10, 8, 6, 4, 6 }, 12.94d)]
        [TestCase(new double[] {6, 1, 10, -5, 2, -5}, 22.42d)]
        [TestCase(new double[] { 0, 14, 0, 13, -1, 13 }, 3.41d)]
        public void GetRightPerimeterTriangle(double[] coordinates, double expected_perimeter)
        {
            Triangle testing_triangle = new Triangle(Program.GetPoints(coordinates));
            double actual_perimeter = testing_triangle.GetPerimetr();
            Assert.That(expected_perimeter, Is.EqualTo(actual_perimeter));
        }
        [TestCase(new double[8] { -6, 10, 1, 10, 1, 3, -6, 3 }, 28d)]
        [TestCase(new double[8] { -1, 14, 0, 14, 0, 13, -1, 13 }, 4d)]
        [TestCase(new double[] { 6, 10, 8, 6, 6, 2, 4, 6 }, 17.89d)]
        [TestCase(new double[] { 6, 1, 10, -5, 6, -11, 2, -5 }, 28.84d)]
        public void GetRightPerimeterRhombus(double[] coordinates, double expected_perimeter)
        {
            Rhombus testing_rhombus = new Rhombus(Program.GetPoints(coordinates));
            double actual_perimeter = testing_rhombus.GetPerimetr();
            Assert.That(expected_perimeter, Is.EqualTo(actual_perimeter));
        }
        [TestCase(new double[] { -6, 10, 1}, 6.28d)]
        [TestCase(new double[] { -1, 14, 5}, 31.42d)]
        [TestCase(new double[] { 6, 10, 8}, 50.27d)]
        [TestCase(new double[] { 6, 1, 10}, 62.83)]
        public void GetRightPerimeterCircle(double[] coordinates, double expected_perimeter)
        {
            Circle testing_circle = new Circle(Program.GetPoints(coordinates.Take(coordinates.Length - 1).ToArray()), coordinates.Last());
            double actual_perimeter = testing_circle.GetPerimetr();
            Assert.That(expected_perimeter, Is.EqualTo(actual_perimeter));
        }
        [TestCase(new double[] { -6, 10, 4, 5, 6, 7, 10, 2 }, 42.28d)]
        [TestCase(new double[] { -1, 14, 4, 5, 6, 7, 5, 5 }, 31.42d)]
        [TestCase(new double[] { 6, 10, 4, 5, 6, 7, 8, 1 }, 32.95d)]
        [TestCase(new double[] { 6, 1, 4, 5, 6, 7, 49, 14 }, 214.61d)]
        public void GetRightPerimeterElips(double[] coordinates, double expected_perimeter)
        {
            Elips testing_elips = new Elips(Program.GetPoints(coordinates.Take(6).ToArray()), /*left_focus: coordinates[2], right_focus: coordinates[3],*/ first_half_axis: coordinates[6], second_half_axis: coordinates[7]);
            double actual_perimeter = testing_elips.GetPerimetr();
            Assert.That(expected_perimeter, Is.EqualTo(actual_perimeter));
        }
        [TestCase(new double[8] { -1, 1, 2, 1, 2, -1, -1, -1 }, 6d)]
        [TestCase(new double[8] { 4, 10, 8, 10, 8, 3, 4, 3 }, 28d)]
        [TestCase(new double[8] { -10, 10, 1, 10, 1, 3, -10, 3 }, 77d)]
        [TestCase(new double[8] { -1, 14, 0, 14, 0, 13, -1, 13 }, 1d)]
        public void GetRightAreaRectangle(double[] coordinates, double expected_area)
        {
            Rectangle testing_rectangle = new Rectangle(Program.GetPoints(coordinates));
            double actual_area = testing_rectangle.GetArea();
            Assert.That(expected_area, Is.EqualTo(actual_area));
        }
        [TestCase(new double[8] { -6, 10, 1, 10, 1, 3, -6, 3 }, 49d)]
        [TestCase(new double[8] { 4, 10, 8, 10, 8, 6, 4, 6 }, 16d)]
        [TestCase(new double[8] { -1, 1, 1, 1, 1, -1, -1, -1 }, 4d)]
        [TestCase(new double[8] { -1, 14, 0, 14, 0, 13, -1, 13 }, 1d)]
        public void GetRighAreaSquare(double[] coordinates, double expected_area)
        {
            Square testing_square = new Square(Program.GetPoints(coordinates));
            double actual_area = testing_square.GetArea();
            Assert.That(expected_area, Is.EqualTo(actual_area));
        }
        [TestCase(new double[] { -6, 8, 1, 3, -6, 3 }, 17.49d)]
        [TestCase(new double[] { 6, 10, 8, 6, 4, 6 }, 7.99d)]
        [TestCase(new double[] { 6, 1, 10, -5, 2, -5 }, 23.99d)]
        [TestCase(new double[] { 0, 14, 0, 13, -1, 13 }, 0.50d)]
        public void GetRightAreaTriangle(double[] coordinates, double expected_area)
        {
            Triangle testing_triangle = new Triangle(Program.GetPoints(coordinates));
            double actual_area = testing_triangle.GetArea();
            Assert.That(expected_area, Is.EqualTo(actual_area));
        }
        [TestCase(new double[8] { -6, 10, 1, 10, 1, 3, -6, 3 }, 49.00d)]
        [TestCase(new double[8] { -1, 14, 0, 14, 0, 13, -1, 13 }, 1.00d)]
        [TestCase(new double[] { 6, 10, 8, 6, 6, 2, 4, 6 }, 16.00d)]
        [TestCase(new double[] { 6, 1, 10, -5, 6, -11, 2, -5 }, 48.00d)]
        public void GetRightAreaRhombus(double[] coordinates, double expected_area)
        {
            Rhombus testing_rhombus = new Rhombus(Program.GetPoints(coordinates));
            double actual_area = testing_rhombus.GetArea();
            Assert.That(expected_area, Is.EqualTo(actual_area));
        }
        [TestCase(new double[] { -6, 10, 1 }, 3.14d)]
        [TestCase(new double[] { -1, 14, 5 },78.54d)]
        [TestCase(new double[] { 6, 10, 8 }, 201.06d)]
        [TestCase(new double[] { 6, 1, 10 }, 314.16d)]
        public void GetRightAreaCircle(double[] coordinates, double expected_area)
        {
            Circle testing_circle = new Circle(Program.GetPoints(coordinates.Take(coordinates.Length - 1).ToArray()), coordinates.Last());
            double actual_area = testing_circle.GetArea();
            Assert.That(expected_area, Is.EqualTo(actual_area));
        }
        [TestCase(new double[] { -6, 10, 4, 5, 6, 7, 10, 2 }, 62.83d)]
        [TestCase(new double[] { -1, 14, 4, 5, 6, 7, 5, 5 }, 78.54d)]
        [TestCase(new double[] { 6, 10, 4, 5, 6, 7, 8, 1 }, 25.13d)]
        [TestCase(new double[] { 6, 1, 4, 5, 6, 7, 49, 14 }, 2155.13d)]
        public void GetRightAreaElips(double[] coordinates, double expected_area)
        {
            Elips testing_elips = new Elips(Program.GetPoints(coordinates.Take(6).ToArray()),first_half_axis: coordinates[6], second_half_axis: coordinates[7]);
            double actual_area = testing_elips.GetArea();
            Assert.That(expected_area, Is.EqualTo(actual_area));
        }
    }
}