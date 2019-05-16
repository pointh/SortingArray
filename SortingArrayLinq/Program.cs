using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArray
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double DistanceTo0()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        
        public override string ToString()
        {
            return string.Format("X: {0}, Y: {1}, Dist: {2}", X, Y, DistanceTo0());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point { X = 2.0, Y = 3.0 };
            Point q = new Point { X = 3.0, Y = 3.0 };
            Point r = new Point { X = 2.7, Y = 1.2 };

            Point[] points = { p, q, r };

           
            foreach (var v in points)
                Console.WriteLine(v);

            Console.WriteLine("\n\n---------- Po setřídění LINQ podle vzdálenosti od (0, 0) ----------\n");

            var sortedByDistance0 = from point in points
                         orderby point.DistanceTo0()
                         select point;
                         //select point.DistanceTo0(; // když chceš zobrazit jen vzdálenost

            foreach (var v in sortedByDistance0)
                Console.WriteLine(v);

            Console.WriteLine("\n\n---------- Po setřídění LINQ podle souřadnice X ----------\n");

            var sortedByX = from point in points
                                    orderby point.X
                                    select point;

            foreach (var v in sortedByX)
                Console.WriteLine(v);

            Console.ReadLine();

        }
    }
}
