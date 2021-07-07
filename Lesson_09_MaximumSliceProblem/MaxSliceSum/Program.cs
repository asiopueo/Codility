using System;

namespace MaxSliceSum
{
    class Solution {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public static int solution(int[] A) {
            int maxSliceSum = int.MinValue;
            int currentSum = 0;

            foreach (int element in A) {
                currentSum = Math.Max(element, currentSum+element);
                maxSliceSum = Math.Max(maxSliceSum, currentSum);
            }
            
            return maxSliceSum; // 5
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {3,2,-6,4,0};

            int result = Solution.solution(A);

            Console.WriteLine($"{result}");
        }
    }
}
