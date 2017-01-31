using System;
using System.Linq;

namespace _05_CompareCharArrays
{
    class Compare
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            bool isFirstSmaller = false;

            for (int i = 0; i < Math.Min(firstArray.Length,secondArray.Length); i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    if (i == Math.Min(firstArray.Length, secondArray.Length) - 1)
                    {
                        if (firstArray.Length < secondArray.Length)
                        {
                            isFirstSmaller = true;
                            break;
                        }
                    }
                    continue;
                }
                else if (firstArray[i].CompareTo(secondArray[i])<0)
                {
                    isFirstSmaller = true;
                    break;
                }
                else
                {
                    break;
                }
            }

            if (isFirstSmaller)
            {
                foreach (var letter in firstArray)
                {
                    Console.Write(letter);
                }
                Console.WriteLine();
                foreach (var letter in secondArray)
                {
                    Console.Write(letter);
                }
            }
            else
            {
                foreach (var letter in secondArray)
                {
                    Console.Write(letter);
                }
                Console.WriteLine();
                foreach (var letter in firstArray)
                {
                    Console.Write(letter);
                }
            }
        }
    }
}
