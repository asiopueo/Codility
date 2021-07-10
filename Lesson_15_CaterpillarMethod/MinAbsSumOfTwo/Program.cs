using System;

namespace MinAbsSumOfTwo
{
    class Solution {
        // Brute-force solution: O(N**2)
        // Time complexity: O(N*log(N))
        // Space complexity: O(1)
        public static int solution(int[] A) {
            int minSum = int.MaxValue;
            int absSum = int.MaxValue;
            int sum = 0;
            Array.Sort(A); // O(N*log(N))

            int left = 0;
            int right = A.Length-1;
            
            while (left <= right) { // O(N)
                sum = A[left] + A[right];
                absSum = Math.Abs(sum);
                minSum = Math.Min(minSum, absSum);

                if (sum <= 0)
                    left++;
                else
                    right--;

            }

            return minSum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //int[] A = new int[] {1,4,-3}; // expected: |4+(-3)|=1
            int[] A = new int[] {-8,4,5,-10,3}; // expected: |(-8)+5|=3
            // Sorted: A = {-10,-8,3,4,5}
            int result = Solution.solution(A);
            Console.WriteLine($"{result}");
        }
    }
}
