using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems.Problem_Solving.Algorithms.Implementation.ClimbingTheLeaderboard
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem
    /// </summary>
    public class ClimbingTheLeaderboardSolve
    {
        public static List<int> Solve(List<int> ranked, List<int> player)
        {
            List<int> listResult = new List<int>();

            var ranked_dist = ranked.Distinct().ToArray();

            foreach (int i in player)
            {
                int left = 0;
                int right = ranked_dist.Length - 1;
                while (left <= right)
                {
                    int mid = left + (right - left) / 2;
                    if (i < ranked_dist[mid])
                        left = mid + 1;
                    else
                        right = mid - 1;
                }

                listResult.Add(left + 1);
            }

            return listResult;
        }
    }
}
/*
 ERROR de Timeout, al enviar

INPUT: https://hr-testcases-us-east-1.s3.amazonaws.com/29530/input06.txt?response-content-type=text%2Fplain&X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAR6O7GJNX5DNFO3PV%2F20240821%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20240821T230644Z&X-Amz-Expires=7200&X-Amz-SignedHeaders=host&X-Amz-Signature=aacd6ac20e25917a1bf8f2f5484ec55d728c935bf5d3fce973391efcb1bb8a78
 */


/*
    List<int> result = new List<int>();

    var ranked_dist = ranked.Distinct().ToList();

    foreach (int i in player)
    {

        ranked_dist.Add(i);
        var tmp2 = ranked_dist.OrderByDescending(x => x).ToList();

        result.Add(tmp2.IndexOf(i) + 1);
    }

    return result;
}
 */

/*
             List<int> listResult = new List<int>();

            var ranked_dist = ranked.Distinct();

            foreach (int i in player)
            {
                int result = 0;

                if (i > ranked_dist.Max()) { result = 1; }
                else if(i < ranked_dist.Min()) {  result = ranked_dist.Count() + 1; }
                else {
                    result = ranked_dist.Count(x => x > i) + 1;
                }

                listResult.Add(result);
            }

            return listResult;
 
 */