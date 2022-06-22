using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.InterviewPreparationKit._02.Arrays
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
    /// </summary>
    public class LeftRotation
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

    class SolutionLeftRotation
    {
        public static void GetSolution()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> result = LeftRotation.RotLeft(a, d);

            Console.WriteLine(String.Join(" ", result));

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
