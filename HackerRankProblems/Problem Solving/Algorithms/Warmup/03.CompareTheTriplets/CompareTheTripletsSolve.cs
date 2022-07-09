using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Warmup.CompareTheTriplets
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/simple-array-sum/problem
    /// </summary>
    public class CompareTheTripletsSolve
    {
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            int pa = 0;
            int pb = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if(a.ElementAt(i) > b.ElementAt(i)){
                    pa++;
                }
                else if(a.ElementAt(i) < b.ElementAt(i))
                {
                    pb++;
                }
            }

            return new List<int>() { pa, pb };
        }
    }
}