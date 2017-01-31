using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_RotateAndSum
{
    class RotateArray
    {
        static void Main(string[] args)
        {

            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int r = int.Parse(Console.ReadLine());
            int[] reversed=new int[numbers.Length];
            int[] sum = new int[reversed.Length];

                for (int i = 0; i < numbers.Length; i++)
                {
                    reversed[((i + r)%numbers.Length)] = numbers[i];
                    //sum[i] += reversed[i] + numbers[i];
                }

            Console.WriteLine(string.Join(" ",reversed));
        }
    }
}
