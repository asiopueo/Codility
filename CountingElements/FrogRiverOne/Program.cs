using System;
using System.Collections.Generic;

namespace FrogRiverOne
{
    class Solution {
        // Runtime complexity: O(N) for the length of the array
        // Space complexity: O(X) for the hash table
        public static int solution(int X, int[] A) {
            var hashSet = new HashSet<int>();

            int i=0;
            while (hashSet.Count != X && i < A.Length) {
                hashSet.Add(A[i]);
                i++;
            }

            if (hashSet.Count == X)
                return i-1;
            else
                return -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int X = 5;
            int[] A = new int[] {1,3,1,4,2,3,5,4};
            int result = Solution.solution(X, A);
            if (result != -1)
                Console.WriteLine($"The frog may cross the river after {result} seconds.");
            else
                Console.WriteLine($"The frog may never cross the river: {nameof(result)}={result}.");
        }
    }
}
