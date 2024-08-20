using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.BonAppetit
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/bon-appetit/problem
    /// </summary>
    public class BonAppetitSolve
    {
        /*
         * Complete the 'bonAppetit' function below.
         *
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY bill
         *  2. INTEGER k
         *  3. INTEGER b
         */

        public static void Solve(List<int> bill, int k, int b)
        {
            int exclude = bill.ElementAt(k);
            bill.Remove(exclude);
            int amount = bill.Sum() / 2;

            if (amount == b)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(b - amount);
            }
        }
    }
}