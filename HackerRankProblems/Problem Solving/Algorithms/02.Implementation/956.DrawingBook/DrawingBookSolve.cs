using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.DrawingBook
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/drawing-book/problem
    /// </summary>
    public class DrawingBookSolve
    {
        /*
         * Complete the 'bonAppetit' function below.
         *
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY bill
         *  2. INTEGER k
         *  3. INTEGER b
         */

        public static int Solve(int n, int p)
        {
            int nP = int.IsOddInteger(p) ? p - 1 : p; 
            return p == 1 || p == n ? 0 : ((p > n / 2) ? n - nP : p) / 2;
        }
    }
}