using System;

namespace PermMissingElem
{
    class Solution {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public static int solution(int[] A) {
            int sum = 0;
            for (int i=0; i<A.Length; i++) {
                sum += A[i];
            }
            return ((A.Length+1)*(A.Length+2)/2 - sum);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {2,3,1,5};
            int result = Solution.solution(A);
            Console.WriteLine($"{result}");
        }
    }
}
