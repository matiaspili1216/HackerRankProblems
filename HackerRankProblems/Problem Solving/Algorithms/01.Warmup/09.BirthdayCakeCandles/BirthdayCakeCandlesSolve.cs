using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Warmup.BirthdayCakeCandles
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/birthday-cake-candles/problem
    /// </summary>
    public class BirthdayCakeCandlesSolve
    {
        public static int BirthdayCakeCandles(List<int> candles)
        {
            int max = candles.Max();
            return candles.Count(x => x == max);
        }
    }
}