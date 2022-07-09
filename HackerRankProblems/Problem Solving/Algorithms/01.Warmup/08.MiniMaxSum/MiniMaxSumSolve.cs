using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Warmup.MiniMaxSum
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/mini-max-sum/problem
    /// </summary>
    public class MiniMaxSumSolve
    {
        public static void MiniMaxSum(List<int> arr)
        {
            List<long> allSum = new List<long>();
            long sum = arr.Select(x => long.Parse(x.ToString())).Sum();

            for (int i = 0; i < arr.Count; i++)
            {
                allSum.Add(sum - arr.ElementAt(i));
            }

            Console.WriteLine($"{allSum.Min()} {allSum.Max()}");
        }
    }
}