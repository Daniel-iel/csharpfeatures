using System.Drawing;

namespace csharp7Features.Tuples
{
    class Car
    {
        public (string, string) GetModelAndColor()
        {
            var (_, c) = GetModelAndColor1();

            return ("Honda", c);
        }

        public (string model, string color) GetModelAndColor1()
        {
            var p = new Point(3.14, 2.71);
            (double X, double Y) = p;


            //return ("Honda", "Black");
            return (model: "Honda", color: "Black");
        }
    }

    public class Point
    {
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; }
        public double Y { get; }

        public void Deconstruct(out double x, out double y)
        {
            x = this.X;
            y = this.Y;
        }
    }
}
