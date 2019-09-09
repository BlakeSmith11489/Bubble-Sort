using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sorted = false;

            int[] arrayToSort = { 45, 6, 12, 51, 4, 23, 31 };

           
            Console.WriteLine("Array numbers are out of order.");
            for(int i= 0; i < arrayToSort.Length; i++)
            {
                Console.WriteLine(arrayToSort[i]);
            }


            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("The array is sorted now.");

            while (!sorted)
            {
                sorted = true;
                int l;
                for (int i = 0; i < arrayToSort.Length - 1; i++)
                {

                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        l = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i + 1];
                        arrayToSort[i + 1] = l;
                        sorted = false;
                    }
                    else
                        continue;
                } 
            }

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.WriteLine(arrayToSort[i]);
            }
            Console.ReadKey();
        }
    }
}
