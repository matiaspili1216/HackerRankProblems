using System;

namespace HackerRankProblems.Problem_Solving.Algorithms.Warmup.TimeConversion
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/time-conversion/problem
    /// </summary>
    public static class TimeConversionPrepare
    {
        public static void Call()
        {
            string s = Console.ReadLine();

            string result = TimeConversionSolve.TimeConversion(s);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}