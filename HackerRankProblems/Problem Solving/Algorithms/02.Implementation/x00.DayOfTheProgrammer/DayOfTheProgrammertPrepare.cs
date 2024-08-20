using System;
using System.Collections.Generic;
using System.IO;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.DayOfTheProgrammer
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/day-of-the-programmer/problem
    /// </summary>
    public class DayOfTheProgrammerPrepare
    {
        public static void Call()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int year = Convert.ToInt32(Console.ReadLine().Trim());

            string result = DayOfTheProgrammerSolve.Solve(year);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}