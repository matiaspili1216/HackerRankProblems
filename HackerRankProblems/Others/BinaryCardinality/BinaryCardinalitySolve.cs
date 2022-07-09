using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Others.BinaryCardinality
{
    public class BinaryCardinalitySolve
    {
        /// <summary>
        /// Sort a list of decimal number by Binary Cardinality
        /// </summary>
        /// <param name="nums">List of decimal number</param>
        /// <returns>List of decimal number sorted</returns>
        public static List<int> SortByCardinality(List<int> nums) => nums.OrderBy(x => GetBinaryCardinality(DecToBin(x))).ThenBy(x => x).ToList();

        /// <summary>
        /// Get Binary Cardinality (quantity of 1 in a Binary representation)
        /// </summary>
        /// <param name="bin">Binary representation</param>
        /// <returns>Binary Cardinality</returns>
        private static int GetBinaryCardinality(List<int> bin) => bin.Count(x => x == 1);

        /// <summary>
        /// COnvert decimal number to Binary repesentation
        /// </summary>
        /// <param name="dec">Decimal number to convert</param>
        /// <returns>Binary repesentation</returns>
        private static List<int> DecToBin(int dec)
        {
            List<int> result = new();

            int temp = dec;
            for (int i = 0; temp > 0; i++)
            {
                result.Add(temp % 2);
                temp /= 2;
            }

            return result;
        }
    }
}
