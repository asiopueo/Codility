using System;

namespace MaxProductOfThree
{
    class Solution {
        public static int solution(int[] A)
        {
            // 2 cases: All intergers are positive, or two and only two are negative
            // Corner case: triple contains '0'
            Array.Sort(A); // O(N*log N)
            int maxSum = Math.Max(A[0]*A[1]*A[A.Length-1], A[A.Length-3]*A[A.Length-2]*A[A.Length-1]);
            return maxSum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {-3, 1, 2, -2, 5, 6};

            int result = Solution.solution(array);
            Console.WriteLine($"{result}");
        }
    }
}
