using System;

namespace FrogJmp
{
    class Solution {
        public static int solution(int X, int Y, int D) {
            return (Y-X)%D==0 ? (Y-X)/D : (Y-X)/D+1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int X = 10;
            int Y = 85;
            int D = 30;
            int result = Solution.solution(X,Y,D);
            Console.WriteLine($"{result}");
        }
    }
}
