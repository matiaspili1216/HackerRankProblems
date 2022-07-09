using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Warmup.SimpleArraySum
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/solve-me-first/problem
    /// </summary>
    public class SimpleArraySumPrepare
    {
        public void Call()
        {

            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = SimpleArraySumSolve.SimpleArraySum(ar);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}