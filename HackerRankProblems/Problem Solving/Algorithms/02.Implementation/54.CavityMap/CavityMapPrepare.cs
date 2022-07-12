using System;
using System.Collections.Generic;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.CavityMap
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/cavity-map/problem
    /// </summary>
    public class CavityMapPrepare
    {
        public static void Call()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> grid = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string gridItem = Console.ReadLine();
                grid.Add(gridItem);
            }

            List<string> result = CavityMapSolve.CavityMap(grid);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(String.Join("\n", result));
            Console.ReadLine();
        }
    }
}
