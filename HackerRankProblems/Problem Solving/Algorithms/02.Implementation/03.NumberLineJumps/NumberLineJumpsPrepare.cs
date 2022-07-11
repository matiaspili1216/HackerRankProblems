using System;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.NumberLineJumps
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/kangaroo/problem
    /// </summary>
    public class NumberLineJumpsPrepare
    {
        public static void Call()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int x1 = Convert.ToInt32(firstMultipleInput[0]);

            int v1 = Convert.ToInt32(firstMultipleInput[1]);

            int x2 = Convert.ToInt32(firstMultipleInput[2]);

            int v2 = Convert.ToInt32(firstMultipleInput[3]);

            string result = NumberLineJumpsSolve.Kangaroo(x1, v1, x2, v2);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}