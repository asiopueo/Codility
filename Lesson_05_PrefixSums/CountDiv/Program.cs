using System;

namespace CountDiv
{
    class Solution {
        // Time complexity: O(1)
        // Space complexity: O(1)
        public static int solution(int A, int B, int K) {
            if ( (B-A)%K == 0 )
                return (B-A)/K;
            else
                return (B-A)/K + 1 ;
        }

        public static int solution2(int A, int B, int K) {
            return (B-A)/K + ((B-A)%K==0 ? 0 : 1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int A=6, B=11, K=2; // 3 expected
            //int A=7, B=31, K=5; // 5 expected
            //int A=16, B=342, K=17; // 20 expected
            int result = Solution.solution2(A,B,K);
            Console.WriteLine($"{result}");
        }
    }
}
