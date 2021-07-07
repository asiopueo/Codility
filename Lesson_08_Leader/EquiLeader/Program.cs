using System;

namespace EquiLeader
{
    class Solution {
        // Time complexity: O(N) ?
        // Space complexity: O(1)
        public static int solution(int[] A) {
            int counter = 0;
            int leaderA, leaderB;

            int candidateCounter = 0;
            int candidate = A[0];
            for (int i=1; i<A.Length; i++) {

                if (A[i].Equals(candidate))
                    candidateCounter++;
                else if (candidateCounter > 0)
                    candidateCounter--;
                else
                    candidate = A[i];
            }

            Console.WriteLine($"The initial candidate is {candidate}");

            for (int i=0; i<A.Length; i++) {
                
                if (leaderA.Equals(leaderB))
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
