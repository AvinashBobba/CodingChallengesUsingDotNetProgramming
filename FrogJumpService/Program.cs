using System;
using System.Linq;

namespace FrogJumpService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Solution(10,10,10));
        }

        public static int Solution(int X, int Y, int D)
        {
            int count = 0;
            if (Enumerable.Range(1, 1000000000).Contains(X) &&
                Enumerable.Range(1, 1000000000).Contains(Y) &&
                Enumerable.Range(1, 1000000000).Contains(D))
            {
                if (X <= Y)
                {
                    while (X <= Y)
                    {
                        count++;
                        X += D;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            else
            {
                Console.WriteLine("Passed values should be in the  range 1 and 1000000000");
            }

            return count;
        }
    }
}
