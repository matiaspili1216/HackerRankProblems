using System;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.DrawingBook
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/drawing-book/problem
    /// </summary>
    public class DrawingBookPrepare
    {
        public static void Call()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int p = Convert.ToInt32(Console.ReadLine().Trim());

            int result  = DrawingBookSolve.Solve(n, p);

            Console.WriteLine(result);
        }
    }
}