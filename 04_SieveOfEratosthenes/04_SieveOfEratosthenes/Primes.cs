using System;

namespace _04_SieveOfEratosthenes
{
    class Primes
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 2; i < range; i++)
            {
                for (int j = 2; j <range; j++)
                {
                    if (i%j == 0)
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.Write(i+ " ");
                }
                count = 0;
            }
        }
    }
}
