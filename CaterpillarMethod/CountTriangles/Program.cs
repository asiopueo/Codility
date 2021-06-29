using System;

namespace CountTriangles
{
    class Solution {
        public static int solution(int[] A) {
            int counter = 0;
            Array.Sort(A); // O(N log N)

            int end = A.Length-1;
            // ...


            return counter;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {10, 2, 5, 1, 8, 12};
            int result = Solution.solution(A);
            Console.WriteLine($"{result}");
        }
    }
}
