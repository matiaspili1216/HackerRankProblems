using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Warmup.MiniMaxSum
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/mini-max-sum/problem
    /// </summary>
    public static class MiniMaxSumPrepare
    {
        public static void Call()
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
            MiniMaxSumSolve.MiniMaxSum(arr);

            Console.ReadLine();
        }
    }
}