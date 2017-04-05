using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillarPencilKata
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr1 = new int[] { 2, 3, 5, 7, 9 };
            int[] intArr2 = new int[] { 3, 2, 4, 9, 10, 15 };

            Console.WriteLine("Matching numbers: {0}",
               FindMatchingIntegers(intArr1, intArr2));
        }

        public static int[] FindMatchingIntegers(int[] array1, int[] array2)
        {


            Array.Sort(array1);
            Array.Sort(array2);

            int[] newArray = new int[10];

            if (array1.Length > array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] == array2[i])
                    {
                        newArray[i] = array1[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < array2.Length; i++)
                {
                    if (array2[i] == array1[i])
                    {
                        newArray[i] = array2[i];
                    }
                }
            }

            return newArray;

        }
    }
}
