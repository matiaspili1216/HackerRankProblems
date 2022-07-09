using System;

namespace HackerRankProblems.Problem_Solving.Algorithms.Warmup.Staircase
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/staircase/problem
    /// </summary>
    public static class StaircasePrepare
    {
        public static void Call()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            StaircaseSolve.Staircase(n);

            Console.ReadLine();
        }
    }
}