using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRankProblems
{
    /*
     * https://www.hackerrank.com/challenges/2d-array/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
    */
    public class _2DArrayDS
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

    class Solution_2DArrayDS
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < 6; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = _2DArrayDS.HourglassSum(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
