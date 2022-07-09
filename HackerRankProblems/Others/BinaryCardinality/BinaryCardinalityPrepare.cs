using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Others.BinaryCardinality
{
    public class BinaryCardinalityPrepare
    {
        public static void Call()
        {
            Console.Write("Enter the number to convert (without spaces and separate by commas): ");

            string values = Console.ReadLine();

            List<int> nums = values.Split(',').Select(x => int.Parse(x)).ToList();

            Console.Write($"Res = {string.Join(", ", BinaryCardinalitySolve.SortByCardinality(nums))}");

            Console.ReadLine();
        }
    }
}
