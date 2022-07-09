using System;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.TheTimeInWords
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/the-time-in-words/problem?isFullScreen=true&utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign
    /// </summary>
    public class TheTimeInWordsPrepare
    {
        public static void Call()
        {
            int h = Convert.ToInt32(Console.ReadLine().Trim());

            int m = Convert.ToInt32(Console.ReadLine().Trim());

            string result = TheTimeInWordsSolve.TimeInWords(h, m);

            Console.WriteLine(result);
            Console.ReadLine();
        }

    }
}
