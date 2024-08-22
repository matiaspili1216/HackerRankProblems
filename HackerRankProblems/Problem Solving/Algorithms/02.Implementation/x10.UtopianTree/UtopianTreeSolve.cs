namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.UtopianTree
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/utopian-tree/problem
    /// </summary>
    public class UtopianTreeSolve
    {
        public static int Solve(int n)
        {
            int result = 1;

            if(n == 0) { return 1; }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if(i % 2 == 0) {  
                        result++; 
                    }
                    else
                    {
                        result *= 2;
                    }
                }
            }
            return result;
        }
    }
}