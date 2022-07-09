using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.InterviewPreparationKit.Array.DosDArrayDS
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/2d-array/problem
    /// </summary>
    public class DosDArrayDSSolve
    {
        /*
     * Complete the 'hourglassSum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

        public static int HourglassSum(List<List<int>> arr)
        {
            return GetAllHourglass(arr).Max(x => x.Sum());
        }

        public static List<int[]> GetAllHourglass(List<List<int>> arr)
        {

            List<int[]> result = new List<int[]>();

            int len = arr.Count;
            int max = len - 2;

            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    int[] tmp = new int[7]
                    {
                    arr.ElementAt(i).ElementAt(j),
                    arr.ElementAt(i).ElementAt(j + 1),
                    arr.ElementAt(i).ElementAt(j + 2),
                    arr.ElementAt(i + 1).ElementAt(j + 1),
                    arr.ElementAt(i + 2).ElementAt(j),
                    arr.ElementAt(i + 2).ElementAt(j + 1),
                    arr.ElementAt(i + 2).ElementAt(j + 2)
                    };
                    result.Add(tmp);
                }
            }
            return result;
        }
    }
}