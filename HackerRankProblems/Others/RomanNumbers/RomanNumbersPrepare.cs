using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Others.RomanNumbers
{
    public class RomanNumbersPrepare
    {
        public static void Call()
        {
            Console.Write("Enter list of names with roman number (Ej. 'Luis XI') to sort (without spaces and separate by commas): ");

            string values = Console.ReadLine();

            List<string> names = values.Split(',').ToList();

            Console.Write($"Res = {string.Join(", ", RomanNumbersSolve.SortByNamesAndRoman(names))}");

            Console.ReadLine();
        }
    }
}