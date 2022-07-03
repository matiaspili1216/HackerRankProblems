using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/the-time-in-words/problem?isFullScreen=true&utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign
    /// </summary>
    public class TheTimeInWordsResult
    {
        private static string NumberToText(int m)
        {
            return m switch
            {
                1 => "one",
                2 => "two",
                3 => "three",
                4 => "four",
                5 => "five",
                6 => "six",
                7 => "seven",
                8 => "eight",
                9 => "nine",
                10 => "ten",
                11 => "eleven",
                12 => "twelve",
                13 => "thirteen",
                14 => "fourteen",
                15 => "quarter",
                16 => "sixteen",
                17 => "seventeen",
                18 => "eighteen",
                19 => "nineteen",
                20 => "twenty",
                21 => "twenty one",
                22 => "twenty two",
                23 => "twenty three",
                24 => "twenty four",
                25 => "twenty five",
                26 => "twenty six",
                27 => "twenty seven",
                28 => "twenty eight",
                29 => "twenty nine",
                30 => "half",
                _ => "",
            };
        }

        public static string TimeInWords(int h, int m)
        {
            if(m == 0) { return $"{NumberToText(h)} o' clock"; }

            string pastTo = m <= 30 ? "past" : "to";
            int mm = m <= 30 ? m : 60 - m;
            int hh = m <= 30 ? h : h + 1;

            if (mm == 1)
            {
                return $"one minute {pastTo} {NumberToText(hh)}";
            }
            else if (mm == 15)
            {
                return $"quarter {pastTo} {NumberToText(hh)}";
            }
            else if (mm == 30)
            {
                return $"half {pastTo} {NumberToText(hh)}";
            }
            else
            {
                return $"{NumberToText(mm)} minutes {pastTo} {NumberToText(hh)}";
            }
        }

    }

    public class TheTimeInWordsSolution
    {
        public static void Solve()
        {
            int h = Convert.ToInt32(Console.ReadLine().Trim());

            int m = Convert.ToInt32(Console.ReadLine().Trim());

            string result = TheTimeInWordsResult.TimeInWords(h, m);

            Console.WriteLine(result);
            Console.ReadLine();
        }

    }
}
