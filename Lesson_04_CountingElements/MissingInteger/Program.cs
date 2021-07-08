using System;
using System.Collections.Generic;
using System.Linq;

namespace MissingInteger
{
    class Solution {
        // Time complexity: O()
        // Space complexity: O(N)
        public static int solution(int[] A) {
            HashSet<int> hashSet = new HashSet<int>();
            int maxElement = 1;

            foreach (int entry in A) {
                hashSet.Add(entry);
                maxElement = Math.Max(maxElement, entry);
            }

            for(int i=1; i<=Math.Max(1, maxElement); i++)
                if( !hashSet.Contains(i) )
                    return i;
            
            return maxElement+1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {1,3,6,4,1,2}; // 5
            //int[] A = new int[] {1,2,3}; // 4
            //int[] A = new int[] {-1,-3}; // 1
            int result = Solution.solution(A);
            Console.WriteLine($"{result}");
        }
    }
}
