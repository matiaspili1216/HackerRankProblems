using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.BetweenTwoSets
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/between-two-sets/problem
    /// </summary>
    public class BetweenTwoSetsSolve
    {
        public static int GetTotalX(List<int> a, List<int> b)
        {
            var comunFac = ComunFactors(b);

            int result = 0;

            foreach (var f in comunFac)
            {
                if(a.All(x => f % x == 0)) { result++; }
            }

            return result;
        }

        private static List<int> ComunFactors(List<int> values)
        {
            List<int> facs = new List<int>();

            foreach (var value in values.OrderByDescending(x => x))
            {
                var f = Factors(value);
                if (facs.Any())
                {
                    var newFacts = f.Where(x => facs.Contains(x)).ToList();
                    facs = newFacts;
                }
                else
                {
                    facs = f;
                }
            }

            return facs;
        }

        private static List<int> Factors(int value)
        {
            List<int> result = new List<int>() { value };

            for (int i = 1; i <= value / 2; i++)
            {
                if(value % i == 0) { result.Add(i); }
            }

            return result;
        }
    }
}