using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Warmup.DiagonalDifference
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/diagonal-difference/problem
    /// </summary>
    public static class DiagonalDifferencePrepare
    {
        public static void Call()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = DiagonalDifferenceSolve.DiagonalDifference(arr);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}