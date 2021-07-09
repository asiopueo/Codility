using System;
using System.Collections.Generic;
using System.Linq;

namespace Peaks
{
    class Solution {
        // Time complexity: O()
        // Space complexity: O()
        public static int solution(int[] A) 
        {
            int N = A.Length;
            if (N<2) return 0;
         
            List<int> peaks = new List<int>();

            for (int i=1; i<N-1; i++)
                if(A[i-1]<A[i] && A[i+1]<A[i]) 
                    peaks.Add(i);

            for (int i=1; i<=N; i++) {
                if (N%i!=0 || N/i > peaks.Count)
                    continue;

                HashSet<int> hashSet = new HashSet<int>();

                for(int j=0; j<N/i; j++) {
                    foreach(var peak in peaks)
                        if (j*i <= peak && peak < (j+1)*i)
                            hashSet.Add(j);
                }

                if (hashSet.Count == N/i)
                    return N/i;

            }

            return 0; // expected: 3
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {1,2,3,4,3,4,1,2,3,4,6,2}; // peaks 3,5,10
            int result = Solution.solution(A);
            Console.WriteLine($"{result}");
        }
    }
}
