using System;

namespace NumberSolitaire
{
    class Solution {
        // Time complexity: O(N)
        // Space complexity: O(N)
        public static int solution(int[] A) {
            int[] dp = new int[A.Length];
            dp[0] = A[0];
            int tmp = int.MinValue, max = int.MinValue;

            for(int curr=1; curr<A.Length; curr++) {
                dp[curr] = A[curr];
                max = int.MinValue;
                for (int dice=1; dice<=6; dice++) {
                    if (curr-dice >= 0)
                        tmp = dp[curr] + dp[curr-dice];
                        max = Math.Max(max, tmp);
                }
                dp[curr] = max;
            }

            return dp[A.Length-1];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {1,-2,0,9,-1,-2};
            int result = Solution.solution(A);
            Console.WriteLine($"{result}");
        }
    }
}
