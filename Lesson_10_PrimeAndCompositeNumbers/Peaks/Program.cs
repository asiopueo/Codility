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
            List<int> peaks = new List<int>();

            for (int i=1; i<A.Length; i++)
                if(A[i-1]<A[i] && A[i+1]<A[i]) 
                    peaks.Add(i);

            foreach(var item in peaks)
                Console.Write($"{item}, ");                

            for (int i=peaks[0]+1; i<=peaks[1]; i++) {
                if 
                // else
                // return 0;
                    
            }

            return int.MinValue; // expected: 3
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
