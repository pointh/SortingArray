using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingArray
{
    class Point : IComparable
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double DistanceTo0()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        public int CompareTo(object p)
        {
            return this.DistanceTo0() < (p as Point).DistanceTo0() ? -1 : 1;
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

            foreach ( var v in points )
                Console.WriteLine(v);

            Console.WriteLine("\n---------- Po setřídění IComparable ----------\n");

            Array.Sort(points);

            foreach (var v in points)
                Console.WriteLine(v);

            Console.ReadLine();

        }
    }
}
