using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Warmup.DiagonalDifference
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/simple-array-sum/problem
    /// </summary>
    public class DiagonalDifferenceSolve
    {
        public static int DiagonalDifference(List<List<int>> arr)
        {
            int max = arr.Count;
            int xD1 = 0;
            int yD1 = 0;

            int xD2 = 0;
            int yD2 = max -1;

            int sumD1 = 0;
            int sumD2 = 0;

            for (int x = 0; x < max; x++)
            {
                var row = arr.ElementAt(x);

                for (int y = 0; y < max; y++)
                {
                    if(x == xD1 && y == yD1) { 
                        sumD1 += row.ElementAt(y);
                        xD1++;
                        yD1++;
                    }

                    if (x == xD2 && y == yD2)
                    {
                        sumD2 += row.ElementAt(y);
                        xD2++;
                        yD2--;
                    }
                }
            }

            return Math.Abs(sumD1 - sumD2);
        }
    }
}