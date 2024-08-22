using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.AngryProfessor
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/angry-professor/problem
    /// </summary>
    public class AngryProfessorPrepare
    {
        public static void Call()
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int n = Convert.ToInt32(firstMultipleInput[0]);

                int k = Convert.ToInt32(firstMultipleInput[1]);

                List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

                string result = AngryProfessorSolve.Solve(k, a);

                Console.WriteLine(result);
            }
        }
    }
}