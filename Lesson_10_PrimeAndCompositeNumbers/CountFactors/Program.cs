using System;

namespace CountFactors
{
    class Solution {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public static int solutionBF(int N) {
            int counter = 0;
            
            for (int i=1; i<N+1; i++) {
                if (N%i==0)
                    counter++;
            }

            return counter;
        }

        // Time complexity: O(sqrt(N))
        // Space complexity: O(1)
        public static int solution(int N) {
            int sqrtN = (int) Math.Sqrt(N);
            int counter = 0;

            for (int i=1; i < sqrtN+1; i++) {
                if (N%i==0)
                    counter += 2;
            }

            return counter;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int N = 24;

            int result = Solution.solution(N);

            Console.WriteLine($"{result}");
        }
    }
}
