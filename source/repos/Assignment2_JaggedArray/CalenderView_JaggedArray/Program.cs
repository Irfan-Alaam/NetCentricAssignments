using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderView_JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calender View using Jagged Array
            int[][] calender = new int[12][];

            calender[0]= new int[31];
            calender[1] = new int[28];
            calender[2] = new int[31];
            calender[3] = new int[30];
            calender[4] = new int[31];
            calender[5] = new int[30];
            calender[6] = new int[31];
            calender[7] = new int[31];
            calender[8] = new int[30];
            calender[9] = new int[31];
            calender[10] = new int[30];
            calender[11] = new int[31];

            for (int month = 0; month < calender.Length; month++)
            {
                for (int day = 0; day < calender[month].Length; day++)
                {
                    calender[month][day] = day + 1;
                }
            }
                for (int month = 0; month < calender.Length; month++)
                {
                    Console.WriteLine($"Month{month + 1}:");
                    for (int day = 0; day < calender[month].Length ; day++)
                    {
                    Console.Write($"{calender[month][day]} ");
                    }
                    Console.WriteLine();

                }
            }
    }
}
