using System;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.UtopianTree
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/utopian-tree/problem
    /// </summary>
    public class UtopianTreePrepare
    {
        public static void Call()
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                int result = UtopianTreeSolve.Solve(n);

                Console.WriteLine(result);
            }
        }
    }
}