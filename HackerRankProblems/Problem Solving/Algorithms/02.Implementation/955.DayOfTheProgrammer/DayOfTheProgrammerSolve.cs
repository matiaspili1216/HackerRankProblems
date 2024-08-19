using System;
using System.Collections.Generic;
using System.Globalization;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.DayOfTheProgrammer
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/day-of-the-programmer/problem
    /// </summary>
    public class DayOfTheProgrammerSolve
    {
        private static readonly string LeapProgDate = "12.09";
        private static readonly string NoLeapProgDate = "13.09";
        private static readonly string R1918ProgDate = "26.09";

        public static string Solve(int year)
        {
            string initProgrDate = year == 1918
                ? R1918ProgDate
                : year < 1918
                    ? new JulianCalendar().IsLeapYear(year) ? LeapProgDate : NoLeapProgDate
                    : new GregorianCalendar().IsLeapYear(year) ? LeapProgDate : NoLeapProgDate;
            return $"{initProgrDate}.{year}";
        }
    }
}