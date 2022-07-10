using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Warmup.BirthdayCakeCandles
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/birthday-cake-candles/problem
    /// </summary>
    public static class BirthdayCakeCandlesPrepare
    {
        public static void Call()
        {
            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = BirthdayCakeCandlesSolve.BirthdayCakeCandles(candles);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}