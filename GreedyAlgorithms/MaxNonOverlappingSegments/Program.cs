using System;

namespace MaxNonOverlappingSegments
{
    class Solution {
        // Since the topic is about greedy algorithms, we simply proceed by iterating from left to right.
        // However, it is in my opinion not evident that this will lead to an optimal solution.
        public static int solution(int[] A, int[] B) {
            int counter = 0;

            for (int i=0; i<A.Length; i++) {
                counter++;
                
            }

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
