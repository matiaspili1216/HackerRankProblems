using System.Linq;

/// <summary>
/// https://www.hackerrank.com/challenges/repeated-string/problem
/// </summary>
namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.RepeatedString
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