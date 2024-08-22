using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.TheHurdleRace
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/the-hurdle-race/problem
    /// </summary>
    public class TheHurdleRacePrepare
    {
        public static void Call()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> height = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(heightTemp => Convert.ToInt32(heightTemp)).ToList();

            int result = TheHurdleRaceSolve.Solve(k, height);

            Console.WriteLine(string.Join("\n", result));
        }
    }
}