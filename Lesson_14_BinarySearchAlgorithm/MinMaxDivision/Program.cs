using System;

namespace MinMaxDivision
{
    class Solution {
        private static bool checkDivisibility(int k, int threshold, int[] a) 
        {
            int sum = 0;
            for (int i=0; i<a.Length; i++) {
                sum += a[i];
                if (sum > threshold) {
                    sum = a[i];
                    k--;
                }
                if (k==0)
                    return false;
            }
            return true;
        }

        public static int solution(int K, int M, int[] A) 
        {
            int left = 0;
            int right = 0;

            for (int i=0; i<A.Length; i++) {
                right += A[i];
            }

            int mid = -1;
            while (left < right) 
            {
                mid = (right+left)/2;
                
                if (checkDivisibility(K, mid, A))
                    right = mid;
                else    
                    left = mid+1;
            }

            return mid; // 6
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int K = 3;
            int M = 5;
            int[] A = new int[] {2,1,5,1,2,2,2};
            int result = Solution.solution(K,M,A);
            Console.WriteLine($"The MinMax is: {result}");
        }
    }
}
