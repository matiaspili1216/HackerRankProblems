using System;

namespace HackerRankProblems.Problem_Solving.Algorithms.Warmup.SolveMeFirst
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/solve-me-first/problem
    /// </summary>
    public class SolveMeFirstPrepare
    {
        int val1 = Convert.ToInt32(Console.ReadLine());
        int val2 = Convert.ToInt32(Console.ReadLine());
        int sum = SolveMeFirst.Solve(val1, val2);
        Console.WriteLine(sum);
    }
}