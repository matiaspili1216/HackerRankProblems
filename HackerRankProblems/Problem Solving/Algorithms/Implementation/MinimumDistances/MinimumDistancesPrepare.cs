using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.MinimumDistances
{
    public class MinimumDistancesPrepare
    {
        public static void Call()
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = MinimumDistancesSolve.MinimumDistances(a);

            Console.WriteLine(result);
        }
    }
}