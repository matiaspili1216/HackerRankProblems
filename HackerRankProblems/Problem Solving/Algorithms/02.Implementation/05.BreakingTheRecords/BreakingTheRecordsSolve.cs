using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.BreakingTheRecords
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem
    /// </summary>
    public class BreakingTheRecordsSolve
    {
        public static List<int> BreakingRecords(List<int> scores)
        {
            int minCount = 0;
            int maxCount = 0;
            int min = scores.ElementAt(0);
            int max = scores.ElementAt(0);

            foreach (var score in scores)
            {
                if(score < min)
                {
                    minCount++;
                    min = score;
                }

                if(score > max)
                {
                    maxCount++;
                    max = score;
                }
            }

            return new List<int>() { maxCount, minCount};
        }
    }
}