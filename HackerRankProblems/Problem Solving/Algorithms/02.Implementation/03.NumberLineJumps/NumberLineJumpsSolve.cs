using System;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.NumberLineJumps
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/kangaroo/problem
    /// </summary>
    public class NumberLineJumpsSolve
    {
        public static string Kangaroo(int x1, int v1, int x2, int v2)
        {
            if(v2 > v1 || v1 == v2) { return "NO"; }
            else
            {
                float jumps = (x2 - x1) / (float)(v1 - v2);

                return jumps == Math.Round(jumps, 0) ? "YES" : "NO";
            }
        }
    }
}