using System;
using System.IO;

namespace HackerRankProblems.InterviewPreparationKit.WarmUpChallenges.CountingValleys
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/counting-valleys/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
    /// </summary>

    class CountingValleysPrepare
    {
        public static void Call()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int steps = Convert.ToInt32(Console.ReadLine().Trim());

            string path = Console.ReadLine();

            int result = CountingValleysSolve.GetCountingValleys(steps, path);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
