using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Warmup.PlusMinus
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/plus-minus/problem
    /// </summary>
    public static class PlusMinusPrepare
    {
        public static void Call()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            PlusMinusSolve.PlusMinus(arr);

            Console.ReadLine();
        }
    }
}