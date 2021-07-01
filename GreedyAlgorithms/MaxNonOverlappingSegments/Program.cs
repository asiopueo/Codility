using System;

namespace MaxNonOverlappingSegments
{
    class Solution {
        // Since the topic is about greedy algorithms, we simply proceed by iterating from left to right.
        // However, it is in my opinion not evident that this will lead to an optimal solution.
        // Time complexity: O(N)
        // Space complexity: O(1)
        public static int solution(int[] A, int[] B) {
            int counter = 0;
            int currentEnd = int.MinValue;

            if (A.Length == 0 || B.Length == 0 || A.Length != B.Length)
                return -1;

            for (int i=0; i<A.Length-1; i++) {
                while(A[i] <= currentEnd) {
                    i++;
                }
                currentEnd = B[i];
                counter++;
            }

            if (A[A.Length-1]>currentEnd)
                counter++;

            return counter;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {1,3,7,9,9};
            int[] B = new int[] {5,6,8,9,10};
            int result = Solution.solution(A, B);
            Console.WriteLine($"{result}");
        }
    }
}
