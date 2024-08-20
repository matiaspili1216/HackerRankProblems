namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.DrawingBook
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/drawing-book/problem
    /// </summary>
    public class DrawingBookSolve
    {
        public static int Solve(int n, int p)
        {
            int nP = int.IsOddInteger(p) ? p - 1 : p; 
            return p == 1 || p == n ? 0 : ((p > n / 2) ? n - nP : p) / 2;
        }
    }
}