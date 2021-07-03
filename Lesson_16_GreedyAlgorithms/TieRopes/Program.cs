using System;

namespace TieRopes
{
    class Solution {
        // Time complexity: O(N)
        // Space complexity: O(1)
        // Proof of optimality: ???
        public static int solution(int K, int[] A) {
            int counter = 0;

            int ropeLength = 0;
            for (int i=0; i<A.Length; i++)
            {
                ropeLength += A[i];
                if (ropeLength >= K) {
                    counter++;
                    ropeLength = 0;
                }
            }

            return counter;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int K = 4;
            int[] A = new int[] {1,2,3,4,1,1,3};
            int result = Solution.solution(K,A);
            Console.WriteLine($"The number of ropes with length greater than or equal to {nameof(K)}={K} is: {result}");
        }
    }
}
