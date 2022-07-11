using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.JumpingOnTheClouds
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem
    /// </summary>

    public class JumpingOnTheCloudsPrepare
    {
        public static void Call()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();

            int result = JumpingOnTheCloudsSolve.GetJumpingOnClouds(c);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
