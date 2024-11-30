using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubbleSort
{
    public class BubbleSort
    {
        
        public void Sort(uint[] array)
        {
            int n = array.Length;

            
            for (int i = 0; i < n - 1; i++)
            {
                
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        
                        uint temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        Console.WriteLine($"After swapping elements at index {j} and {j + 1}:");
                        PrintArray(array);
                    }
                }
            }
        }

        public void PrintArray(uint[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
