using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://www.hackerrank.com/challenges/repeated-string/problem?isFullScreen=true&h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup
/// </summary>
namespace HackerRankProblems.InterviewPreparationKit._01.WarmUpChallenges
{
    public class RepeatedString
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

    class SolutionRepeatedString
    {
        public static void GetSolution()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = RepeatedString.GetRepeatedString(s, n);

            Console.WriteLine(result);
            Console.ReadLine();

            //textWriter.WriteLine(result);
            //
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
