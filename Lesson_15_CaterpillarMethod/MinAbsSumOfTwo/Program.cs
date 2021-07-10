using System;

namespace MinAbsSumOfTwo
{
    class Solution {
        public static int solution(int[] A) {
            int sum ;

            for (int i=0; i<A.Length; i++) {
                
            }

            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {1,4,-3}; // expected: |4+(-3)|=1
            //int[] A = new int[] {-8,4,5,-10,3}; // expected: |(-8)+5|=3
            int result = Solution.solution(A);
            Console.WriteLine($"{result}");
        }
    }
}
