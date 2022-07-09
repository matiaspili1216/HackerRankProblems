using System.Collections.Generic;

namespace HackerRankProblems.InterviewPreparationKit.WarmUpChallenges.JumpingOnTheClouds
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
    /// </summary>
    public class JumpingOnTheCloudsSolve
    {
        public static int GetJumpingOnClouds(List<int> c)
        {
            int result = 0;
            int currentStep = 0;

            int limit = c.Count - 1;

            do
            {
                int nextStep = currentStep + 2;

                if (nextStep <= limit && c[nextStep] == 0)
                {
                    result++;
                    currentStep = nextStep;
                }
                else
                {
                    nextStep = currentStep + 1;

                    if (nextStep <= limit && c[nextStep] == 0)
                    {
                        result++;
                        currentStep = nextStep;
                    }
                }

            } while (currentStep < limit);

            return result;
        }
    }
}