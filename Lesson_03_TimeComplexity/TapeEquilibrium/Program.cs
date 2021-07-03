using System;

namespace TapeEquilibrium
{
    class Solution {
        // Time complexity: O(N)
        // Space complexity: O(N) due to the prefix sum
        public static int solution(int[] A) {
            int min = int.MaxValue;
            int[] Prefix = new int[A.Length];
            A.CopyTo(Prefix, 0);

            for (int i=1; i<A.Length; i++)
                Prefix[i] += Prefix[i-1];

            /*foreach(var entry in Prefix)
                Console.Write($"{entry}, ");
            Console.Write(Environment.NewLine);*/

            for(int j=0; j<A.Length-1; j++)
            {
                int abs = Math.Abs(Prefix[A.Length-1]-2*Prefix[j]);
                min = Math.Min(abs, min);
            }
            Console.Write(Environment.NewLine);

            return min;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {3,1,2,4,3};
            int result = Solution.solution(A);
            Console.WriteLine($"{result}");
        }
    }
}
