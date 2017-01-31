using System;

namespace _01_LargestCommonEnd
{
    class CommonEnd
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int maxCount = 0;

            for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {

                if (firstArray[i] == secondArray[i])
                {
                    count1++;
                    if (count1 > maxCount)
                    {
                        maxCount = count1;
                    }
                }
                else
                {
                    if (count1 > maxCount)
                    {
                        maxCount = count1;
                    }

                    count1 = 0;
                }
            }

            for (int i = Math.Min(firstArray.Length, secondArray.Length) - 1; i >= 0; i--)
            {

                if (firstArray[i] == secondArray[i])
                {
                    count2++;
                    if (count2 > maxCount)
                    {
                        maxCount = count2;
                    }
                }
                else
                {
                    if (count2 > maxCount)
                    {
                        maxCount = count2;
                    }
                    count2 = 0;
                }
            }

            //for (int i = 0; i < Math.Min(firstArray.Length,secondArray.Length)-1; i++)
            //{
            //    if (firstArray[firstArray.Length - i] == secondArray[secondArray.Length - i])
            //    {
            //        count3++;
            //        if (count3 > maxCount)
            //        {
            //            maxCount = count3;
            //        }
            //    }
            //    else
            //    {
            //        if (count3>maxCount)
            //        {
            //            maxCount = count3;
            //        }
            //        count3 = 0;
            //    }
            //}

            Console.WriteLine(maxCount);
        }


    }
}
