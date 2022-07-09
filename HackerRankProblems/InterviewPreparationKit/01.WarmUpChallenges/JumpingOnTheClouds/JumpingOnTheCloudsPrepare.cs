using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.InterviewPreparationKit.WarmUpChallenges.JumpingOnTheClouds
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
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
