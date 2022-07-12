using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.InterviewPreparationKit.Array.LeftRotation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem
    /// </summary>
    public class LeftRotationSolve
    {
        /*
          * Complete the 'rotLeft' function below.
          *
          * The function is expected to return an INTEGER_ARRAY.
          * The function accepts following parameters:
          *  1. INTEGER_ARRAY a
          *  2. INTEGER d
          */

        public static List<int> RotLeft(List<int> a, int d)
        {
            var result = a.Skip(d).ToList();
            result.AddRange(a.Take(d).ToList());
            return result;
        }
    }
}