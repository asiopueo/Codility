using System;
using System.Collections.Generic;

namespace GenomicRangeQuery
{
    class Solution {
        static Dictionary<char, int> dict = new Dictionary<char, int>() {
                {'A', 1},
                {'C', 2},
                {'G', 3},
                {'T', 4}
        };

        // Time complexity: O(M*N)
        // Space complexity: O(1)
        public static int[] solutionBF(string S, int[] P, int[] Q) {
            int[] R = new int[P.Length];
            int minImpact = 4;

            for(int i=0; i<P.Length; i++) { // O(M)
                minImpact = 4;
                for(int j=P[i]; j<Q[i]+1; j++) { // O(N)
                    minImpact = Math.Min(minImpact, dict[S[j]]);
                }
                R[i] = minImpact;
            }
            
            return R;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {   
            string S = "CAGCCTA";
            int[] P = new int[] {2,5,0};
            int[] Q = new int[] {4,5,6};

            int[] Result = Solution.solutionBF(S, P, Q); // {2,4,1} expected
            foreach(int item in Result)
                Console.Write($"{item}, ");
        }
    }
}
