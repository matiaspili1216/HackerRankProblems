using System;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.ChocolateFeast
{
    public static class ChocolateFeastPrepare
    {
        public static void Call()
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
