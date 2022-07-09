using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Warmup.AVeryBigSum
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/a-very-big-sum/problem
    /// </summary>
    public class AVeryBigSumPrepare
    {
        public void Call()
        {
            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

            long result = AVeryBigSumSolve.AVeryBigSum(ar);

            Console.ReadLine();
        }
    }
}