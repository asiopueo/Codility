using System;
using System.Collections;
using System.Collections.Generic;

namespace PassingCars
{
    class Solution 
    {
        // Brute force solution: O(N^2) time complexity, O(1) space complexity
        public static int solutionBF(int[] A) 
        {
            int counter = 0;

            for (int i=0; i<A.Length; i++)
            {
                if (A[i] == 0) {
                    for (int j=i+1; j<A.Length; j++) {
                        if (A[j] == 1) {
                            counter++;
                        }
                    }
                }
            }

            return counter;
        }

        // Time complexity: O(N)
        // Space complexity: O(1)
        public static int solution(int[] A)
        {
            int counter = 0;
            int zeroMultiplier = 0;
            
            for(int i=0; i<A.Length; i++)
                if (A[i]==0)
                    zeroMultiplier++;
                else if (A[i]==1)
                    counter += zeroMultiplier;

                if (counter > 1e9)
                    return -1;

            return counter;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {0, 1, 0, 1, 1};
            //int[] array = new int[] {0, 1, 0, 1, 1, 0, 1};

            int result = Solution.solution(array);

            Console.WriteLine($"The solution is {result}.");
        }
    }
}
