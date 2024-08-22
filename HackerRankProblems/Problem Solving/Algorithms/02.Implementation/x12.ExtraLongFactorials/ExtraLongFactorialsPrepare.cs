using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.ExtraLongFactorials
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/extra-long-factorials/problem
    /// </summary>
    public class ExtraLongFactorialsPrepare
    {
        public static void Call()
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());
            ExtraLongFactorialsSolve.Solve(n);

        }
    }
}