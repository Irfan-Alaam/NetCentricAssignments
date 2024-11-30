using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubbleSort
{
    internal class Program
    {
        static void Main()
        {
            
            uint[] x = { 5, 6, 8, 2, 4, 0, 1 };

            Console.WriteLine("Initial array:");
            PrintArray(x);  

           
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Sort(x);

            Console.WriteLine("Sorted array:");
            PrintArray(x);
        }
        static void PrintArray(uint[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

    }
}
