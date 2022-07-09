using System;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.ChocolateFeast
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/chocolate-feast/problem
    /// </summary>
    public static class ChocolateFeastSolve
    {
        /*
         * Complete the 'chocolateFeast' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER c
         *  3. INTEGER m
         */

        public static int ChocolateFeast(int initialAmount, int cost, int wrappersToFree)
        {
            int result = 0;

            int initialBars = initialAmount / cost;
            result += initialBars;
            int wrappers = initialBars;

            do
            {
                int newBars = wrappers / wrappersToFree;
                int otherWrappers = wrappers % wrappersToFree;
                result += newBars;
                wrappers = otherWrappers + newBars;

            } while (wrappers >= wrappersToFree);

            return result;
        }
    }

    public static class ChocolateFeastSolution
    {
        public static void Solve()
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int n = Convert.ToInt32(firstMultipleInput[0]);

                int c = Convert.ToInt32(firstMultipleInput[1]);

                int m = Convert.ToInt32(firstMultipleInput[2]);

                int result = ChocolateFeastSolve.ChocolateFeast(n, c, m);

                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
