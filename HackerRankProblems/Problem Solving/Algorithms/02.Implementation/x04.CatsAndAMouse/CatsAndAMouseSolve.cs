using System;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.CatsAndAMouse
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/cats-and-a-mouse/problem
    /// </summary>
    public class CatsAndAMouseSolve
    {
        private static readonly string CatA = "Cat A";
        private static readonly string CatB = "Cat B";
        private static readonly string MouseC = "Mouse C";

        public static string Solve(int x, int y, int z)
        {
            int dA = Math.Abs(z - x);
            int dB = Math.Abs(z - y);

            return dA == dB ? MouseC : dA > dB ? CatB : CatA;
        }
    }
}