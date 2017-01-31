using System;
using System.Linq;

namespace _11_EqualSums
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int index = -1;
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int k = 0; k < numbers.Length; k++)
                {
                    if (k < i || i==0)
                    {
                        sum1 += numbers[k];
                    }
                    else if (k>=i+1)
                    {
                        sum2 += numbers[k];
                    }
                }

                if (sum1 == sum2)
                {
                    index = i;
                    Console.WriteLine(i);
                }
                sum1 = 0;
                sum2 = 0;
            }

            if (numbers.Length <= 1)
            {
                Console.WriteLine("0");
            }
            else if (index==-1)
            {
                Console.WriteLine("no");
            }
        }
    }
}
