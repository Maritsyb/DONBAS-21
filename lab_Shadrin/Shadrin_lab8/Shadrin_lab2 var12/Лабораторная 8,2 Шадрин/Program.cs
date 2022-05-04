using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_8_2_Шадрин
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Massive={2124, 3243, 11, 3, 7, 32, 24, 545, 231 };
            bool first;
            int min = 0;
            first = true;
            foreach (int i in Massive)
                if (i % 2 != 0)
                {
                    if (first) 
                    {
                        min = i; 
                        first = false;
                    }
                    else
                    {
                        if (min > i)
                            min = i;
                    }
                }                        
            Console.WriteLine("Минимальное нечетное число в массиве = " + min);
        }
        
    }
}
