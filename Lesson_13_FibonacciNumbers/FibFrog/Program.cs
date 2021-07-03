using System;
using System.Collections.Generic;

namespace FibFrog
{
    class Fibonacci {
        List<int> fib = new List<int>() {0, 1};

        private int CalculateFibunacci(int n) {
            int index = fib.Count;
            while (index <= n) {
                fib.Add(fib[index-2]+fib[index-1]);
                index++;
            }
            return fib[n];
        }

        public int GetFibonacci(int n) {
            int lastIndex = fib.Count-1;
            if (n <= lastIndex)
                return fib[n];
            else {
                return CalculateFibunacci(n);
            }
        }
    }

    class Solution {
        // Time complexity: O()
        // Space complexity: O()
        public static int solution(int[] A) {
            // Greedy algorithm
            int pos = -1;

            Fibonacci fib = new Fibonacci();

            return fib.GetFibonacci(13);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {0,0,0,1,1,0,1,0,0,0,0};
            int result = Solution.solution(A);
            Console.WriteLine($"{result}");
        }
    }
}
