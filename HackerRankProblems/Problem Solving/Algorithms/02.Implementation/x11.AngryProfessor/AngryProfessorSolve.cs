using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.AngryProfessor
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/angry-professor/problem
    /// </summary>
    public class AngryProfessorSolve
    {
        public static string Solve(int k, List<int> a)
        {   
            return a.Where(x => x <= 0).Count() >= k ? "NO" : "YES";
        }
    }
}