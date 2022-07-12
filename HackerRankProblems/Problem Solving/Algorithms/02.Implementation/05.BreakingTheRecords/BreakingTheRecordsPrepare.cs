using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.BreakingTheRecords
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem
    /// </summary>
    public class BreakingTheRecordsPrepare
    {
        public static void Call()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

            List<int> result = BreakingTheRecordsSolve.BreakingRecords(scores);

            Console.WriteLine(string.Join(" ", result));

            Console.ReadLine();
        }
    }
}