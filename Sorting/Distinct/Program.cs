using System;
using static System.Console;

namespace Distinct
{
    class Solution
    {
        public static int solution(int[] numbersArray) {
            int distinctNumbers = 0;
            Array.Sort(numbersArray);
            
            for (int i=0; i < numbersArray.Length; i++)
            {
                
            }


            return distinctNumbers;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {2, 1, 1, 2, 3, 1};
            int result = Solution.solution(array);

            WriteLine("There are {0} distinct numbers in the array.", result);
        }
    }
}
