using System;

namespace Triangle
{
    class Solution
    {
        public static int solution(int[] A) {
            if (A.Length<3)
                return 0;
            // a < b < c
            // Find the largest c for which there are two numbers a and b such that c < a+b
            // Then: a < b+c and b < c < a+c anyway!
            Array.Sort(A); // O(N log N)
            for (int i=A.Length-1; i>1; i--)
            {
                if (A[i-2]+A[i-1]>A[i])
                    return 1;
            }

            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[] {10, 2, 5, 1, 8, 20};
            int[] array = new int[] {10, 50, 5, 1};

            int result = Solution.solution(array);
            Console.WriteLine($"{result}");
        }
    }
}
