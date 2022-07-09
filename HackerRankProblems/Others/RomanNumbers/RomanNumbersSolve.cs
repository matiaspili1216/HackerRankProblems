using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Others.RomanNumbers
{
    public class RomanNumbersSolve
    {
        /// <summary>
        /// Sort list of names with roman number (Ej. 'Luis XI') by names and roman number
        /// </summary>
        /// <param name="names">List of names with roman number</param>
        /// <returns>List of names with roman number</returns>
        public static List<string> SortByNamesAndRoman(List<string> names) => names.Select(x => x.Split(" ")).OrderBy(x => x[0]).ThenBy(x => RomanToInt(x[1])).Select(x => string.Join(" ", x)).ToList();

        /// <summary>
        /// Conver Roman Number to decimal
        /// </summary>
        /// <param name="roman">Roman number repesentation</param>
        /// <returns>Decimal number</returns>
        public static int RomanToInt(string roman)
        {
            int result = 0;
            Dictionary<char, int> valueDictionary = new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };


            for (int i = 0; i < roman.Length; i++)
            {
                char romanChar = roman[i];
                int n = valueDictionary[romanChar];

                if (i + 1 < roman.Length && valueDictionary[roman[i + 1]] > valueDictionary[romanChar])
                {
                    result -= n;
                }
                else
                {
                    result += n;
                }
            }
            return result;
        }
    }
}
