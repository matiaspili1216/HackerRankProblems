using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.PickingNumbers
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/picking-numbers/problem
    /// </summary>
    public class PickingNumbersPrepare
    {
        public static void Call()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = PickingNumbersSolve.Solve(a);

            Console.WriteLine(result);
        }
    }
}