using System.Linq;

/// <summary>
/// https://www.hackerrank.com/challenges/repeated-string/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
/// </summary>
namespace HackerRankProblems.InterviewPreparationKit.WarmUpChallenges.RepeatedString
{
    public class RepeatedStringSolve
    {
        /*
         * Complete the 'repeatedString' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts following parameters:
         *  1. STRING s
         *  2. LONG_INTEGER n
         */

        public static long GetRepeatedString(string s, long n)
        {
            int sLen = s.Length;
            long numOfRep = (n / sLen);

            long result = numOfRep * s.Count(x => x.Equals('a'));

            if (n % sLen != 0)
            {
                string newS = s.Substring(0, (int)(n % sLen));
                result += newS.Count(x => x.Equals('a'));
            }

            return result;
        }
    }
}