using System;

namespace HackerRankProblems.Problem_Solving.Algorithms.Warmup.SolveMeFirst
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/solve-me-first/problem
    /// </summary>
    public class SolveMeFirstPrepare
    {
        public static void Call()
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = SolveMeFirstSolve.Solve(val1, val2);
            Console.WriteLine(sum);
        }
    }
}