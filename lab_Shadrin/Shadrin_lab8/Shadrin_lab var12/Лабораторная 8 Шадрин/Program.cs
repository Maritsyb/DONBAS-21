using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_8_Шадрин
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int OddNumberCount = 0; 

            Console.WriteLine("Введите начало диапазона чисел");
            int CurrentValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конец диапазона чисел");
            int Limit = Convert.ToInt32(Console.ReadLine());

            while(CurrentValue <= Limit)
            {
                if(CurrentValue / 2 != 0 && CurrentValue < 0)
                {
                    OddNumberCount++;
                }
                CurrentValue++;
            }

            Console.WriteLine("Количество нечетных чисел = " + OddNumberCount);
        }
    }
}
