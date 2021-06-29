using System;
using System.Collections.Generic;

namespace CountDistinctSlices
{
    class Solution {
        public static int solution(int M, int[] A) {
            int counter = 0;
            HashSet<int> hashSet = new HashSet<int>();

            int end;
            for (int start = 0; start<A.Length; start++)
            {
                end = start;
                while (end<A.Length && hashSet.Add(A[end]))
                {
                    end++;
                    counter++;
                }
                hashSet.Clear();
            }

            return counter;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int M = 6;
            int[] A = new int[] {3,4,5,5,2};
            int result = Solution.solution(M, A);
            Console.WriteLine($"{result}");
        }
    }
}
