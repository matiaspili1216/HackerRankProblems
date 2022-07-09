using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.InterviewPreparationKit.WarmUpChallenges.SalesByMatch
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/sock-merchant/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
    /// </summary>
    public class SalesByMatchSolve
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
}