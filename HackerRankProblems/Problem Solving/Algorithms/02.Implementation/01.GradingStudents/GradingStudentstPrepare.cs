using System;
using System.Collections.Generic;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.GradingStudents
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/grading/problem
    /// </summary>
    public class GradingStudentsPrepare
    {
        public static void Call()
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = GradingStudentsSolve.Solve(grades);

            Console.WriteLine(string.Join("\n", result));
            Console.ReadLine();
        }
    }
}