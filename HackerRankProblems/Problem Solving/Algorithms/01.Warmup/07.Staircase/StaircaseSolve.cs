using System;

namespace HackerRankProblems.Problem_Solving.Algorithms.Warmup.Staircase
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/staircase/problem
    /// </summary>
    public class StaircaseSolve
    {
        public static void Staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{Repeat(" ", n - i)}{Repeat("#", i)}");
            }
        }

        private static string Repeat(string s, int len)
        {
            string result = "";
            for (int i = 0; i < len; i++)
            {
                result += s;
            }
            return result;
        }
    }
}