using System;
using System.Drawing;
using System.Linq;

namespace HackerRankProblems.Others.PointsInTriangle
{
    public class PointsInTrianglePrepare
    {
        /*
         Improvement points:
            * Add validations when getting points values
         */
        public void Call()
        {
            Console.WriteLine("Enter value X and Y of Points (without spaces and separate by commas): three point of triangle and one to calculate");

            Console.WriteLine("Point A of triangle:");
            string valuesOfA = Console.ReadLine();
            var pointOfA = valuesOfA.Split(',').Select(x => int.Parse(x));
            Point a = new Point(pointOfA.ElementAt(0), pointOfA.ElementAt(1));

            Console.WriteLine("Point B of triangle:");
            string valuesOfB = Console.ReadLine();
            var pointOfB = valuesOfB.Split(',').Select(x => int.Parse(x));
            Point b = new Point(pointOfB.ElementAt(0), pointOfB.ElementAt(1));

            Console.WriteLine("Point C of triangle:");
            string valuesOfC = Console.ReadLine();
            var pointOfC = valuesOfC.Split(',').Select(x => int.Parse(x));
            Point c = new Point(pointOfC.ElementAt(0), pointOfC.ElementAt(1));


            PointsInTriangleSolve solve = new PointsInTriangleSolve();

            if (!solve.IsNonDegenerate(a, b, c)) { Console.WriteLine("This triangle is Degenerate"); }
            else
            {
                Console.WriteLine("Point P to calculate:");
                string valuesOfP = Console.ReadLine();
                var pointOfP = valuesOfP.Split(',').Select(x => int.Parse(x));
                Point p = new Point(pointOfP.ElementAt(0), pointOfP.ElementAt(1));

                if (solve.PointBelongTriangle(a, b, c, p))
                {
                    Console.WriteLine("This Point belong of triangle");
                }
                else
                {
                    Console.WriteLine("This Point not belong of triangle");
                }
            }

            Console.ReadLine();
        }
    }
}