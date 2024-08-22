using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.ClimbingTheLeaderboard
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem
    /// </summary>
    public class ClimbingTheLeaderboardPrepare
    {
        public static void Call()
        {
            int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();

            int playerCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

            List<int> result = ClimbingTheLeaderboardSolve.Solve(ranked, player);

            Console.WriteLine(string.Join("\n", result));
        }
    }
}