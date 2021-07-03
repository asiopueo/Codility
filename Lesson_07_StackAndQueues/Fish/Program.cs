using System;
using System.Collections.Generic;

namespace Fish
{
    class FishWithSizeAndDirection {
        public int index;
        public int size;
        public int direction;
        public FishWithSizeAndDirection(int index, int size, int direction)
        {
            this.index = index;
            this.size = size;
            this.direction = direction;
        }
    }

    class Solution {
        public static int solution(int[] A, int[] B) {
            Stack<FishWithSizeAndDirection> livingFish = new Stack<FishWithSizeAndDirection>();
            livingFish.Push( new FishWithSizeAndDirection(0,A[0],B[0]) ); 

            for (int i=1; i<A.Length; i++) {

                var lastFish = livingFish.Peek();
                
                if (lastFish.direction==1) {
                    if (B[i]==1)
                        livingFish.Push( new FishWithSizeAndDirection(i, A[i], B[i]) );
                    else if (B[i]==0 && A[i] > lastFish.size) {
                        livingFish.Pop();
                        livingFish.Push( new FishWithSizeAndDirection(i, A[i], B[i]) );
                    }
                }
                else    
                    livingFish.Push( new FishWithSizeAndDirection(i, A[i], B[i]) );
            }

            return livingFish.Count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] {4,3,2,1,5};
            int[] B = new int[] {0,1,0,0,0};
            int result = Solution.solution(A,B);
            Console.WriteLine($"{result} fish will stay alive");
        }
    }
}
