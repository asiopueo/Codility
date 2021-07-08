using System;

namespace MaxCounters
{
    class Solution {
        private static int maxValue = 2;

        // Time complexity: O()
        // Space complexity: O()
        public static int[] solution(int N, int[] Ops) {
            int[] CounterArray = new int[N]; // All entries are initialized to 0

            for (int i=0; i<Ops.Length; i++) {
                if (Ops[i]==N+1) {
                    for(int j=0; j<N; j++)  //
                        CounterArray[j] = maxValue;
                }
                else
                    CounterArray[Ops[i]-1]++;
            }

            return CounterArray;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            int[] A = new int[] {3,4,4,6,1,4,4};
            int[] Result = Solution.solution(N,A);

            foreach(int item in Result)
                Console.Write($"{item}, ");
        }
    }
}
