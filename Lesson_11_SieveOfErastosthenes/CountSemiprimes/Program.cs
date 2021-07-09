using System;

namespace CountSemiprimes
{
    class Solution {
        public static int[] solution(int N, int[] P, int[] Q) 
        {
            for (int i=0; i<P.Length; i++) 
            {
                
            }

            return new int[] {};
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int N = 26;
            int[] P = new int[] {1,4,16};
            int[] Q = new int[] {26,10,20};
            int[] R = Solution.solution(N,P,Q);
            
            foreach (int item in R)
                Console.WriteLine($"{item}, ");
        }
    }
}
