using System;

namespace MinAvgTwoSlice
{
    class Solution {
        // Time complexity: O()
        // Space complexity: O()
        public static int solution(int[] A) {
            //int[] Prefix = new int[A.Length]; 
            var Prefix = (int[]) A.Clone();

            for (int i=1; i<A.Length; i++) // O(N)
                Prefix[i] += Prefix[i-1];
            



            // foreach(var item in Prefix)
            //     Console.Write($"{item}, ");


            return int.MinValue;
        }
    }
    // Consider the counter-example:
    // int[] A = new int[] {-1,-2,-3,-4}; // own counter-example
    // The slice A[0:3] has length 4 and average -1

    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {4,2,2,5,1,5,8}; // expected: 1
            
            int result = Solution.solution(A);
            Console.WriteLine($"{result}");
        }
    }
}
