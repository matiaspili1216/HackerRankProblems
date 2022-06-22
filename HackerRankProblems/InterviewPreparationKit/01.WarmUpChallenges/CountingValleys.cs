﻿using System;
using System.IO;

namespace HackerRankProblems.InterviewPreparationKit._01.WarmUpChallenges
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/counting-valleys/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
    /// </summary>
    public class CountingValleys
    {
        /*
         * Complete the 'countingValleys' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER steps
         *  2. STRING path
         *
         * UDDDUDUU
         */

        public static int GetCountingValleys(int steps, string path)
        {
            int result = 0;
            int currentLevel = 0;
            bool isValley = false;

            for (int i = 0; i < steps; i++)
            {
                isValley = currentLevel < 0;
                currentLevel = path[i].Equals('U') ? currentLevel + 1 : currentLevel - 1;
                if (currentLevel == 0 && isValley) { result++; }
            }

            return result;
        }
    }

    class SolutionCountingValleys
    {
        public static void GetSolution()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int steps = Convert.ToInt32(Console.ReadLine().Trim());

            string path = Console.ReadLine();

            int result = CountingValleys.GetCountingValleys(steps, path);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
