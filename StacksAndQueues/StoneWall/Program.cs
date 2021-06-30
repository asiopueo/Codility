using System;
using System.Collections.Generic;

namespace StoneWall
{
    class Solution {
        public static int solution(int[] H) {
            int counter = 0;
            Stack<int> stack = new Stack<int>();

            for (int i=0; i<H.Length; i++) 
            {
                while (stack.Count!=0 && H[i] < stack.Peek()) {
                    stack.Pop();
                    counter++;
                }
                
                if (stack.Count==0 || H[i] > stack.Peek() )
                    stack.Push(H[i]);
            }

            // Treatment of the last element
            while (stack.Count!=0) {
                    stack.Pop();
                    counter++;
            }

            return counter;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] H = new int[] {8,8,5,7,9,8,7,4,8};
            int result = Solution.solution(H);
            Console.WriteLine($"{result}");
        }
    }
}
