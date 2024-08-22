using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.DesignerPdfViewer
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/designer-pdf-viewer/problem
    /// </summary>
    public class DesignerPdfViewerSolve
    {


        public static int Solve(List<int> h, string word)
        {
            return word.Select(w => h["abcdefghijklmnopqrstuvwxyz".IndexOf(w)]).Max() * word.Length;
        }
    }
}