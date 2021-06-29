using System;

namespace AbsDistinct
{
    class Solution {
        public static int solution(int[] A)
        {
            if (A.Length == 0)
                return 0;

            // Find the smalles entry greater or equal than 0:
            int i = 0;
            while (i<A.Length && A[i]<0) i++;
            int mid = i;
            
            int lastValue = A[mid]; // >=0
            int counter = 1;

            
            if (-A[a]<A[b]) {
                if (lastValue != -A[a]) {
                    lastValue = -A[a];
                    counter++;
                }
                a--;
            }
            else if (-A[a]>A[b]) {
                if (lastValue != A[b]) {
                    lastValue = A[b];
                    counter++;
                }
                b++;
            }
            else
            {
                if (lastValue != A[b]) {
                    lastValue = A[b];
                    counter++;
                }
                a--;
                b++;
            }   

            return counter;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {-5, -3, -1, 0, 3, 6};
            int result = Solution.solution(A);

            Console.WriteLine($"There are {result} distinct absolute values in {nameof(A)}.");
        }
    }
}
