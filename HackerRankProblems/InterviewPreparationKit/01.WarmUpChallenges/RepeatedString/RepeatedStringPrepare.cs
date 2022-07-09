using System;

/// <summary>
/// https://www.hackerrank.com/challenges/repeated-string/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
/// </summary>
namespace HackerRankProblems.InterviewPreparationKit.WarmUpChallenges.RepeatedString
{
    public class RepeatedStringPrepare
    {
        public static void Call()
        {
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = RepeatedStringSolve.GetRepeatedString(s, n);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
