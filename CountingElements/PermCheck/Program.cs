using System;
using System.Collections.Generic;

namespace PermCheck
{
    class Solution {
        // Time complexity: O(N)
        // Space complexity: O(N)
        public static int solution(int[] A) {
            HashSet<int> hashSet = new HashSet<int>();

            int i=0;
            while( i < A.Length && hashSet.Add(A[i]) )
            {
                if (hashSet.Count == A.Length) {
                    // Check if all integers 1..N are contained
                    int j=1; 
                    while( j <= A.Length && hashSet.Remove(j) ) {
                        if (hashSet.Count==0) {
                            return 1;
                        }
                        j++;
                    }
                }
                i++;                
            }

            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {4,1,3,2};
            //int[] A = new int[] {4,1,3};

            int result = Solution.solution(A);
            Console.WriteLine($"{result}");
        }
    }
}
