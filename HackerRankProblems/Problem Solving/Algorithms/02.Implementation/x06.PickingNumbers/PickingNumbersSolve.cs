using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.PickingNumbers
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/picking-numbers/problem
    /// </summary>
    public class PickingNumbersSolve
    {
        public static int Solve(List<int> a)
        {
            int result = 0;
            IOrderedEnumerable<int> a_order = a.OrderBy(a => a);

            foreach (var i in a_order)
            {
                IEnumerable<int> tmp = a_order.Where(x => x >= i && Math.Abs(i - x) <= 1);
                result = Math.Max(result, tmp.Count());
            }

            return result;
        }
    }
}