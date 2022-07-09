using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.InterviewPreparationKit.Array.LeftRotation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem
    /// </summary>
    class LeftRotationPrepare
    {
        public static void Call()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> result = LeftRotationSolve.RotLeft(a, d);

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
