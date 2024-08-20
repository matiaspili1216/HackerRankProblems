using HackerRankProblems.Problem_Solving.Algorithms.Implementation.ElectronicsShop;

using System;
using System.IO;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.CatsAndAMouse
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/cats-and-a-mouse/problem
    /// </summary>
    public class CatsAndAMousePrepare
    {
        public static void Call()
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);

                int y = Convert.ToInt32(xyz[1]);

                int z = Convert.ToInt32(xyz[2]);

                string result = ElectronicsShopSolve.Solve(x, y, z);

                Console.WriteLine(result);
            }

            
        }
    }
}