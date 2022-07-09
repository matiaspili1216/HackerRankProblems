using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.MinimumDistances
{
    public class MinimumDistancesSolve
    {
        /*
         * Complete the 'minimumDistances' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY a as parameter.
         */

        public static int MinimumDistances(List<int> a)
        {
            
            if(a == null || !a.Any()) { return -1; }
            else if(a.Count == a.Distinct().Count()) { return -1; }
            else
            {
                List<int> results = new List<int>();
                List<int> ev = new List<int>();

                for (int i = 0; i < a.Count; i++)
                {
                    int el = a.ElementAt(i);

                    if(a.Count(x => x == el) > 1)
                    {
                        var indexs = GetAllIndexOf(a, el).OrderBy(x => x);

                        for (int j = 0; j < indexs.Count() - 1; j++)
                        {
                            results.Add(Math.Abs(indexs.ElementAt(j) - indexs.ElementAt(j + 1)));
                        }
                    }
                }

                return results.Min();
            }
        }

        private static List<int> GetAllIndexOf(List<int> source, int value)
        {
            return Enumerable.Range(0, source.Count)
             .Where(i => source[i] == value)
             .ToList();
        }
    }

}