using System;

namespace MinPerimenterRectangle
{
    class Solution {
        // The perimeter is minimized is rectangle resembles a square as closely as possible
        // Therefore, we are looking for the greatest integer A, smaller or equal to sqrt(N), s.t. A*B=N
        // Time complexity: O()
        // Space complexity: O(1); some variables below are of course superfluous
        public static int solution(int N) {
            int sqrtN = (int) Math.Sqrt(N);

            int a = sqrtN;
            while (N%a!=0) {
                a--;
            }

            int b = N/a;
            return 2*(a+b); // 22
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int N = 30;
            int result = Solution.solution(N);
            Console.WriteLine($"The smallest perimeter is {result}");
        }
    }
}
