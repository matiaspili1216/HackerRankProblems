using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.InterviewPreparationKit._01.WarmUpChallenges
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
    /// </summary>
    public class JumpingOnTheClouds
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

    class SolutionJumpingOnTheClouds
    {
        public static void GetSolution()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();

            int result = JumpingOnTheClouds.GetJumpingOnClouds(c);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

    }
}
