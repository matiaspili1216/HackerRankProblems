using System;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.ElectronicsShop
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/electronics-shop/problem
    /// </summary>
    public class ElectronicsShopPrepare
    {
        public static void Call()
        {
            string[] bnm = Console.ReadLine().Split(' ');

            int b = Convert.ToInt32(bnm[0]);

            int n = Convert.ToInt32(bnm[1]);

            int m = Convert.ToInt32(bnm[2]);

            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
            ;

            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
            ;
            /*
             * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
             */

            int result  = ElectronicsShopSolve.Solve(keyboards, drives, b);

            Console.WriteLine(result);
        }
    }
}