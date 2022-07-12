using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.BetweenTwoSets
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/between-two-sets/problem
    /// </summary>
    public class BetweenTwoSetsPrepare
    {
        public static void Call()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

            int result = BetweenTwoSetsSolve.GetTotalX(arr, brr);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}