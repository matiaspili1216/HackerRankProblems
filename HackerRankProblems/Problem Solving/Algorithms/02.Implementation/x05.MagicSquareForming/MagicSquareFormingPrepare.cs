using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.MagicSquareForming
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/magic-square-forming/problem
    /// </summary>
    public class MagicSquareFormingPrepare
    {
        public static void Call()
        {
            List<List<int>> s = new List<List<int>>();

            for (int i = 0; i < 3; i++)
            {
                s.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList());
            }

            int result = MagicSquareFormingSolve.Solve(s);

            Console.WriteLine(result);
        }
    }
}