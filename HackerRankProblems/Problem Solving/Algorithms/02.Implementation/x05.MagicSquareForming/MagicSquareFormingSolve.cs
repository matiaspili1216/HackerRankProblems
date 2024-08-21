using System;
using System.Collections.Generic;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.MagicSquareForming
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/magic-square-forming/problem
    /// </summary>
    public class MagicSquareFormingSolve
    {
        public static int Solve(List<List<int>> s)
        {
            int result = int.MaxValue;

            foreach (var square in AllMagicSquare)
            {
                int tmp = Fromating(s, square);
                result = Math.Min(result, tmp);
            }

            return result;
        }

        private static int Fromating(List<List<int>> s, List<List<int>> square)
        {
            int result = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < 3; x++)
                {
                    result += Math.Abs(s[i][x] - square[i][x]);
                }
            }

            return result;
        }

        private static readonly List<List<List<int>>> AllMagicSquare = new List<List<List<int>>>()
        {
            new List<List<int>>() {new List<int> {8,3,4},new List<int> {1,5,9},new List<int> {6,7,2}},
            new List<List<int>>() {new List<int> {4,3,8},new List<int> {9,5,1},new List<int> {2,7,6}},
            new List<List<int>>() {new List<int> {6,7,2},new List<int> {1,5,9},new List<int> {8,3,4}},
            new List<List<int>>() {new List<int> {2,7,6},new List<int> {9,5,1},new List<int> {4,3,8}},
            new List<List<int>>() {new List<int> {8,1,6},new List<int> {3,5,7},new List<int> {4,9,2}},
            new List<List<int>>() {new List<int> {4,9,2},new List<int> {3,5,7},new List<int> {8,1,6}},
            new List<List<int>>() {new List<int> {6,1,8},new List<int> {7,5,3},new List<int> {2,9,4}},
            new List<List<int>>() {new List<int> {2,9,4},new List<int> {7,5,3},new List<int> {6,1,8}}
        };
    }
}