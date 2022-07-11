using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.AppleAndOrange
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/apple-and-orange/problem
    /// </summary>
    public class AppleAndOrangeSolve
    {
        public static void CountApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            Console.WriteLine(apples.Count(ap => Between(a + ap, s, t)));
            Console.WriteLine(oranges.Count(op => Between(b + op, s, t)));
        }

        /// <summary>
        /// Given a value, it calculates if this value is between a minimum and a maximum.
        /// </summary>
        /// <param name="v">Value to calculate</param>
        /// <param name="min">Minimum value</param>
        /// <param name="max">Maximum value</param>
        /// <returns>true if value is between a minimum and a maximum</returns>
        private static bool Between(int v, int min, int max) => min <= v && max >= v;
    }
}