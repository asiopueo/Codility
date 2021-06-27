using System;
using System.Collections;
using System.Collections.Generic;

namespace Brackets
{
    class Solution
    {
        public static int solution(string S)
        {
            char[] str = S.ToCharArray();
            Stack<char> stack = new Stack<char>();
            
            for (int i=0; i<S.Length; i++)
            {
                                
                if (str[i] == '(' || str[i] == '[')
                    stack.Push(str[i]);
                else if (stack.Count != 0) {
                    char lastCharacter = stack.Peek();    
                    if (str[i] == ')' && lastCharacter == '(' || str[i] == ']' && lastCharacter == '[')
                        stack.Pop();
                    else
                        return 0;
                }
                else return 0;
            }

            if (stack.Count == 0)
                return 1;
            else
                return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string s = "[()](";
            int answer = Solution.solution(s);

            Console.WriteLine($"{answer}");
        }
    }
}
