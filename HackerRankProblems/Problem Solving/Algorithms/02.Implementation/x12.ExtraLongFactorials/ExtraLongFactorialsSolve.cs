using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.ExtraLongFactorials
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/extra-long-factorials/problem
    /// </summary>
    public class ExtraLongFactorialsSolve
    {
        public static void Solve(int n)
        {
            BigInteger result = 1;

            for (int i = n; i > 0; i--)
            {
                result *= i;
            }

            Console.WriteLine(result.ToString());
        }
    }
}