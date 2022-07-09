using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Warmup.CompareTheTriplets
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/simple-array-sum/problem
    /// </summary>
    public class CompareTheTripletsPrepare
    {
        public void Call()
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = CompareTheTripletsSolve.CompareTriplets(a, b);

            Console.WriteLine(string.Join(" ", result));

            Console.ReadLine();
        }
    }
}