using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace OddOccuranceInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] A = { 9, 3, 9, 3, 9, 7, 9 };
            
            Console.WriteLine(solution(A));
        }

        public static int solution(int[] A)
        {
            List<int> completed = new List<int>();
            int output = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (!completed.Contains(A[i]))
                {
                    int count = 1;
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if (A[i] == A[j])
                        {
                            count++;
                        }
                    }

                    if (!(count % 2 == 0))
                    {
                        output = A[i];
                    }
                    completed.Add(A[i]);
                }

            }
            return output;
        }
    }
}
