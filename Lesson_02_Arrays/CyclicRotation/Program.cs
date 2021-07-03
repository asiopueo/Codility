using System;

namespace CyclicRotation
{
    // Alternative: Use linked lists?
    class Solution {
        public static int[] solution(int[] A, int K) {
            for(int i=0; i<K; i++)
                rightShift(A);

            return A;
        }

        private static void rightShift(int[] A) {
            int tmp = A[A.Length-1];
            for (int i=A.Length-1; i>0; i--) {
                A[i] = A[i-1];
            }
            A[0] = tmp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {3,8,9,7,6};
            int K = 3;
            int[] result = Solution.solution(A, K);
            
            foreach (int entry in result)
                Console.Write($"{entry}, ");
        }
    }
}
