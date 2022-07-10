using System;

namespace HackerRankProblems.Problem_Solving.Algorithms.Warmup.TimeConversion
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/time-conversion/problem
    /// </summary>
    public class TimeConversionSolve
    {
        public static string TimeConversion(string time)
        {
            return $"{DateTime.Parse(time):HH:mm:ss}";
        }
    }
}