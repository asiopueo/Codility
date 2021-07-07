using System;

namespace EquiLeader
{
    class Solution {
        public static int solution(int[] A) {
            int counter = 0;
            int leaderA, leaderB;

            for (int i=0; i<A.Length; i++) {
                
                if (leaderA == leaderB)
                    counter++;
            }

            return -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {4,3,4,4,4,2};
            int result = Solution.solution(A);

            Console.WriteLine($"The number of equi leaders is: {result}");
        }
    }
}
