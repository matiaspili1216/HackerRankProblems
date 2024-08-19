using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.BonAppetit
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/bon-appetit/problem
    /// </summary>
    public class BonAppetitPrepare
    {
        public static void Call()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            BonAppetitSolve.Solve(bill, k, b);
        }
    }
}