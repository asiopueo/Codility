using System;

namespace CountNonDivisible
{
    class Solution
    {
        // Time complexity: O()
        // Space complexity: O()
        public static int[] solution(int[] A)
        {
            int[] B = new int[A.Length];




            return B;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {3,1,2,3,6};
            int[] result = Solution.solution(A);
            Console.Write("The resulting array is: ");
            foreach(int i in result)
                Console.Write($"{i},");
            Console.WriteLine();
        }
    }
}
