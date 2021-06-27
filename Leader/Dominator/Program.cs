using System;
using System.Collections.Generic;

namespace Dominator
{
    class Solution
    {
        public static int solution(int[] A) {
            int candidateCounter = 1;
            int candidateIdx = 0;
            int candidate = A[0];

            for (int i=1; i < A.Length; i++)
            {
                if (A[i].Equals(candidate))
                    candidateCounter++;
                else if (candidateCounter > 0)
                    candidateCounter--;
                else
                    candidateIdx = i;
                    candidate = A[i];
            }

            // One more iteration, although one could have previously used a dictionary.
            int number = 0;
            for (int i=0; i < A.Length; i++)
                if (candidate == A[i])
                    number++;


            if (A.Length == 0 || 2*number < A.Length+1)
                return -1;
            
            return candidateIdx;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {3, 4, 3, 2, 3, -1, 3, 3};
            //int[] array = new int[] {};

            int result = Solution.solution(array);

            Console.WriteLine($"The solution is {result}");
        }
    }
}
