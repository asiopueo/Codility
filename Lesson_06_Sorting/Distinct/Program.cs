using System;
using static System.Console;

namespace Distinct
{
    class Solution
    {
        
        public static int solution(int[] numbersArray) {
            int distinctNumbers = 1;
            
            if (numbersArray.Length == 0)
                return 0;
            
            Array.Sort(numbersArray); // O(N*log(N))
            
            // O(N)
            for (int i=1; i < numbersArray.Length; i++)
            {
                if (!numbersArray[i].Equals(numbersArray[i-1]))
                {
                    distinctNumbers++;
                }
            }

            return distinctNumbers;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {2, 1, 1, 2, 7, 3, 1};
            int result = Solution.solution(array);

            WriteLine("There are {0} distinct numbers in the array.", result);
            // WriteLine($"There are {result} distinct numbers in the array.");
        }
    }
}
