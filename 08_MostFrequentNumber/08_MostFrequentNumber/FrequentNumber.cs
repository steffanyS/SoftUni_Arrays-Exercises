using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_MostFrequentNumber
{
    class FrequentNumber
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();
            int count = 1;
            int maxCount = 1;
            int index = -1;
            for (int i = 0; i < numbers.Count-1; i++)
            {

                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        index = i;
                    }
                }
                else
                {
                    count = 1;
                }
            }

            Console.WriteLine(numbers[index]);
        }
    }
}
