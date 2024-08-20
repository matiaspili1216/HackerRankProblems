using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.ElectronicsShop
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/electronics-shop/problem
    /// </summary>
    public class ElectronicsShopSolve
    {
        public static int Solve(int[] keyboards, int[] drives, int b)
        {
            List<int> sums = new List<int>();

            foreach (int i in keyboards.Where(x => x < b))
            {
                foreach (int j in drives.Where(x => x < b))
                {
                    sums.Add(i + j);
                }
            }

            var l = sums.Where(x => x <= b);

            return l.Any() ? l.Max() : -1;
        }
    }
}