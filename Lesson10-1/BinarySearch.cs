using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_1
{
    class BinarySearch
    {
        static int? BinarySearch1(int[] num, int val)
        {
            int left = 0;
            int right = num.Length - 1;
            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (num[middle] == val)
                    return middle;
                else
                {
                    if (num[middle]>val)
                    {
                        right = middle - 1;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }
            }
            return null;
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine(BinarySearch1(array,9));
            Console.ReadLine();
        }
    }
}
