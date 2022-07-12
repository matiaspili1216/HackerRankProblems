using System.Collections.Generic;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.GradingStudents
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/grading/problem
    /// </summary>
    public class GradingStudentsSolve
    {
        public static List<int> Solve(List<int> grades)
        {
            List<int> result = new List<int>();

            foreach (var grade in grades)
            {
                if (grade < 38) { result.Add(grade); }
                else
                {
                    int diff = grade % 5;

                    if (diff == 0) { result.Add(grade); }
                    else if (diff > 2) { result.Add(grade + 5 - diff); }
                    else { result.Add(grade); }
                }
            }

            return result;
        }
    }
}