using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.InterviewPreparationKit._01.WarmUpChallenges
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/sock-merchant/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
    /// </summary>
    public class SalesByMatch
    {
        /*
         * Complete the 'sockMerchant' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER_ARRAY ar
         */

        public static int SockMerchant(int n, List<int> ar)
        {
            int result = 0;
            IEnumerable<int> allColors = ar.Distinct();

            foreach (var color in allColors)
            {
                int len = ar.Count(s => s.Equals(color));
                result += (len % 2 == 0) ? len / 2 : (len - 1) / 2;
            }
            return result;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = SalesByMatch.SockMerchant(n, ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}