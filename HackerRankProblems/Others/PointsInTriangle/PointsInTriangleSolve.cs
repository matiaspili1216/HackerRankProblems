using System;
using System.Drawing;

namespace HackerRankProblems.Others.PointsInTriangle
{
    public class PointsInTriangleSolve
    {
        //Fuente: https://www.iteramos.com/pregunta/10693/como-determinar-un-punto-en-un-triangulo

        /// <summary>
        /// Given the points of a trinagle and one extra point, calc if this is into the triangle
        /// </summary>
        /// <param name="a">Point a of triangle</param>
        /// <param name="b">Point b of triangle</param>
        /// <param name="c">Point c of triangle</param>
        /// <param name="p">Extra point to calc</param>
        /// <returns>true is extra point is into the triangle</returns>
        public bool PointBelongTriangle(Point a, Point b, Point c, Point p)
        {
            bool b1 = Sign(a, b, p) < 0.0f; 
            bool b2 = Sign(b, c, p) < 0.0f; 
            bool b3 = Sign(c, a, p) < 0.0f; 
            
            return (b1 == b2) && (b2 == b3);
        }

        static float Sign(Point p1, Point p2, Point pValue)
        {
            return ((pValue.X - p2.X) * (p1.Y - p2.Y)) - ((p1.X - p2.X) * (pValue.Y - p2.Y));
        }

        /// <summary>
        /// Given a value, it calculates if this value is between a minimum and a maximum.
        /// </summary>
        /// <param name="v">Value to calculate</param>
        /// <param name="min">Minimum value</param>
        /// <param name="max">Maximum value</param>
        /// <returns>true if value is between a minimum and a maximum</returns>
        private bool Between(int v, int min, int max) => min <= v && max >= v;

        /// <summary>
        /// If ab, bc, and ca are the lengths of the three sides of a triangle, then
        ///
        /// ab + bc > ca
        /// ab + ca > ab
        /// bc + ca > ab
        /// 
        ///If any one of these inequalities is not true, then we get a degenerate triangle.
        ///
        /// </summary>
        /// <param name="a">Point a of triangle</param>
        /// <param name="b">Point b of triangle</param>
        /// <param name="c">Point c of triangle</param>
        /// <returns>true if is a Non Degenerate triangle</returns>
        public bool IsNonDegenerate(Point a, Point b, Point c)
        {
            var lenAB = LengthSide(a, b);
            var lenBC = LengthSide(b, c);
            var lenAC = LengthSide(a, c);

            return lenAB + lenBC > lenAC && lenBC + lenAC > lenAB && lenAB + lenAC > lenBC;
        }

        /// <summary>
        /// Given two point of triangle, calc length of the side
        /// </summary>
        /// <param name="p1">One point of triangle</param>
        /// <param name="p2">Other point of triangle</param>
        /// <returns></returns>
        private static double LengthSide(Point p1, Point p2)
        {
            return p1.X == p2.X
                ? Math.Abs(p1.Y - p2.X)
                : p1.Y == p2.Y ?
                    Math.Abs(p1.X - p2.X) :
                    Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }
    }
}