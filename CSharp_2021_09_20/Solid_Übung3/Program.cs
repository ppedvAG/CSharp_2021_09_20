using System;

namespace Solid_Übung3
{

    //In der Klasse Programm befindet sich die Im
    class Program
    {
        //static void PrintPoint(IPoint p)
        //{
        //    Console.WriteLine("x={0}, y={1}", p.X, p.Y);
        //}

        //static void Main()
        //{
        //    IPoint p = new Point(2, 3);
        //    Console.Write("My Point: ");
        //    PrintPoint(p);
        //}
    }

    public interface IPoint
    {

    }


    class Point // : IPoint 
    {
        // Constructor:
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Property implementation:
        public int X { get; set; }

        public int Y { get; set; }

        // Property implementation
        public double Distance =>
           Math.Sqrt(X * X + Y * Y);
    }
}
