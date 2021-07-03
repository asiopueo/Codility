using System;
using System.Collections;
using static System.Console;

namespace BinaryGap
{
    class Solution
    {
        public static int solution(int N) {
            int gap = 0;
            bool rightOne = false;

            for (int i = 0; i < 32; i++) {
                int oneHot = (int) Math.Pow(2,i); // Corner case 2^31
                
                if ((N & oneHot) != 0 ) 
                {
                    if (rightOne is false) 
                        rightOne = true;
                    else
                        continue;
                } 
                else if ((N & oneHot) == 0 && (rightOne is true)) 
                {
                    gap++;
                }   
            }

            return gap;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int number = 473; // = (0001 1101 1001)_2
            int gapLength = Solution.solution(number);
            WriteLine("The binary gap has a length of {0}.", gapLength);
        }
    }
}
