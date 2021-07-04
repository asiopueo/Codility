using System;
using System.Collections.Generic;

namespace ChocolatesByNumbers
{
    class Solution {
        // Time complexity: O(N)
        // Space complexity: O(N)
        public static int solution(int N, int M) {
            HashSet<int> hashSet = new HashSet<int>(N);
            int counter = 0;

            int i = 0;
            while (hashSet.Add(i)) {
                counter++;
                i = (i+M)%N;
            }

            return counter;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int N = 10;
            int M = 4;
            int result = Solution.solution(N,M);
            Console.WriteLine($"{result}");
        }
    }
}
