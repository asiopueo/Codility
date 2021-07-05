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
            if (n < fib.Count)
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
            int frogPos = -1;
            int counter = 0;
            Fibonacci fib = new Fibonacci();

            while (frogPos < A.Length+1) {
                for (int i=1; i<=A.Length;i++)
                    if (fib.GetFibonacci(i)+frogPos < A.Length && A[fib.GetFibonacci(i)+frogPos]==1) {
                        frogPos += fib.GetFibonacci(i);
                        counter++;
                        Console.WriteLine(counter);
                        break;
                    }
                    else if (fib.GetFibonacci(i)+frogPos==A.Length)
                        counter++;
            }

            return counter;
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
