using System;

/// <summary>
/// https://www.hackerrank.com/challenges/repeated-string/problem
/// </summary>
namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.RepeatedString
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
