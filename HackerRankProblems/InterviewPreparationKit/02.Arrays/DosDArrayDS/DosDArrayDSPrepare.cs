using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.InterviewPreparationKit.Array.DosDArrayDS
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/2d-array/problem
    /// </summary>
    public class DosDArrayDSPrepare
    {
        public static void Call()
        {
            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < 6; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = DosDArrayDSSolve.HourglassSum(arr);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
