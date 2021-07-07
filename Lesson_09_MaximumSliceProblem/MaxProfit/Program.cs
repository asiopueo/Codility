using System;

namespace MaxProfit
{
    class Solution {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public static int solution(int[] A) {
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            foreach (int spot in A) {
                minPrice = Math.Min(minPrice, spot);
                maxProfit = Math.Max(maxProfit, spot-minPrice);
            }
            
            return maxProfit; // 356
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {23171,21011,21123,21366,21013,21367};
            int result = Solution.solution(A);
            Console.WriteLine($"{result}");
        }
    }
}
