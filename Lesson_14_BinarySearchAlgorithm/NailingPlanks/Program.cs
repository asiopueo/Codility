using System;
using System.Collections.Generic;

namespace NailingPlanks
{
    class Plank : IComparable<Plank> {
        public int start;
        public int end;

        public Plank(int start, int end) {
            this.start = start;
            this.end = end;
        }

        public int CompareTo(Plank o) {
            if (o == null)
                return 1;
                
            return this.start - o.start;
        }
    }

    class Solution {
        // Checks if the nails up to and including i suffice to nail all planks
        static int check(int nailIndex, Plank[] planks, int[] C) {

            int left = 0;
            int right = planks.Length;

            while (left < right) { // O(log(N))
                int mid = (left + right)/2;
                if (planks[mid].end < C[nailIndex])
                    left = mid +1;
                else if (planks[mid].start > C[nailIndex])
                    right = mid;
                else
                    return mid;
            }
            
            return -1;
        }

        // Time complexity: O((N+M)log(N))
        // Space complexity: O()
        public static int solution(int[] A, int[] B, int[] C){
            
            int index = 0;
            Plank[] planks = new Plank[A.Length];


            for (int i=0; i<A.Length; i++) {
                planks[i] = new Plank(A[i], B[i]);
            }

            Array.Sort<Plank>(planks);  // N log(N)

            for (int i=0; i<C.Length; i++) { // O(M)
                check(i, planks, C); // O(log(N))
            }
            
            return index;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {1,4,5,8}; // N = A.Length
            int[] B = new int[] {4,5,9,10}; // N = B.Length
            int[] C = new int[] {4,6,7,10,2}; // M = C.Length
            int result = Solution.solution(A,B,C);
            Console.WriteLine($"{result}");
        }
    }
}
