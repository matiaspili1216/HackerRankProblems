using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.DesignerPdfViewer
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/designer-pdf-viewer/problem
    /// </summary>
    public class DesignerPdfViewerPrepare
    {
        public static void Call()
        {
            List<int> h = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(hTemp => Convert.ToInt32(hTemp)).ToList();

            string word = Console.ReadLine();

            int result = DesignerPdfViewerSolve.Solve(h, word);

            Console.WriteLine(result);
        }
    }
}