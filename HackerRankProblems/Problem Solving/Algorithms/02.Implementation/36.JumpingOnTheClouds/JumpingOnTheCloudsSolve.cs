using System.Collections.Generic;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.JumpingOnTheClouds
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem
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