using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.TheHurdleRace
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/the-hurdle-race/problem
    /// </summary>
    public class TheHurdleRaceSolve
    {
        public static int Solve(int k, List<int> height) => Math.Max(0, height.Max() - k);
    }
}