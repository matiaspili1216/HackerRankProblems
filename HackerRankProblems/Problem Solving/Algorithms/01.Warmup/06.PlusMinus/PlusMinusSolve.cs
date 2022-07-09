using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Warmup.PlusMinus
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/plus-minus/problem
    /// </summary>
    public class PlusMinusSolve
    {
        public static void PlusMinus(List<int> arr)
        {
            int t = arr.Count;
            float cP = arr.Count(x => x > 0);
            float c0 = arr.Count(x => x == 0);
            float cN = arr.Count(x => x < 0);

            Console.WriteLine($"{cP / t:0.000000}");
            Console.WriteLine($"{cN / t:0.000000}");
            Console.WriteLine($"{c0 / t:0.000000}");
        }
    }
}