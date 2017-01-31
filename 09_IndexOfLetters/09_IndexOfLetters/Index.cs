using System;

namespace _09_IndexOfLetters
{
    class Index
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                 Console.WriteLine("{0} -> {1}",word[i],(int)word[i]-97);
            }
        }
    }
}
