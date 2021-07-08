using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrencesInArray
{
    class Solution {
        // Time complexity: O(N)
        // Space complexity: O(N)
        public static int solution(int[] A) {
            Dictionary<int, int> hashTable = new Dictionary<int, int>();
            
            for (int i=0; i<A.Length; i++)
            {
                int occurrence = hashTable.GetValueOrDefault(A[i]);
                hashTable[A[i]] = occurrence+1;
            }

            var value = hashTable.Where(e => e.Value % 2 == 1).Single().Key;
            return value;
        }

        // Time complexity: O(N)
        // Space complexity: O(N)
        public static int solution2(int[] A)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach(int element in A) {
                if(!dict.ContainsKey(element))
                    dict.Add(element, 1);
                else if (dict.ContainsKey(element) && dict[element]==1)
                    dict.Remove(element);
                else
                    dict[element]--;

            }

            return dict.First().Key;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {9,3,9,3,9,7,9};
            int result = Solution.solution(A);
            Console.WriteLine($"The redundant element in the array is: {result}");
        }
    }
}
