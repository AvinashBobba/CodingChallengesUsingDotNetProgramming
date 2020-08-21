using System;

namespace CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 2, 3, 4 };
           
            Solution(A,4);
        }

        public static int[] Solution(int[] A,int K)
        {
            int[] n = new int[A.Length];
            while (K > 0)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (i == A.Length - 1)
                    {
                        n[i] = A[0];
                    }
                    else
                    {
                        n[i] = A[i + 1];
                    }
                }
                K--;
                n.CopyTo(A, 0);
            }
            return n;
        }
    }
}
