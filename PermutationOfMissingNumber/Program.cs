using System;
using System.Linq;

namespace PermutationOfMissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] b = { 1, 2, 9, 4, 5, 6, 7, 8, 10 };
            var c = BubleSort(b);
        }

        public static void solution(int[] A)
        {
            
            int[] b = { 1,2,9,4,5,6,7,8,10};  

            int a = b.Length;
            int c = a + 1;
        }

        public static int[] BubleSort(int[] A)
        {
            int count = A.Count();
            int temp;
            for (int i = 0; i < A.Length-1; i++)
            {
                for (int p = 0; p < A.Length-1; p++)
                {
                    if(A[p] > A[p + 1])
                    {
                        temp = A[p+1];
                        A[p + 1] = A[p];
                        A[p] = temp;
                    }
                }
            }
            return A;
        }
    }
}
