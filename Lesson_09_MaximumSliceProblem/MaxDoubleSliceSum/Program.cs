using System;
using System.Collections.Generic;

namespace MaxDoubleSliceSum
{
    class Solution {
        // Time complexity: O(N)
        // Space complexity: O(N)
        public static int solution(int[] A) 
        {
            int currentSum = 0;
            int maxSliceSum = int.MinValue;

            int[] Sum1 = new int[A.Length]; // Max sum ending at index i
            int[] Sum2 = new int[A.Length]; // Max sum starting at index i

            for (int i=1; i<A.Length; i++) {
                currentSum = Math.Max(A[i], currentSum+A[i]);
                maxSliceSum = Math.Max(maxSliceSum, currentSum);
            }

            for (int i=A.Length-1; i>0; i--) {
                currentSum = Math.Max(A[i], currentSum+A[i]);
                maxSliceSum = Math.Max(maxSliceSum, currentSum);
            }

            int maxDoubleSliceSum = int.MinValue;

            for (int i=1; i<A.Length-1; i++)
                maxDoubleSliceSum = Math.Max(maxDoubleSliceSum, Sum1[i-1]+Sum2[i+1]);

            return maxDoubleSliceSum; 
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {3,2,6,-1,4,5,-1,2}; // expected: 17
            int result = Solution.solution(A);
            Console.WriteLine($"{result}");
        }
    }
}
