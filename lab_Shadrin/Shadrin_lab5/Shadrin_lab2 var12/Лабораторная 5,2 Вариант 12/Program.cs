using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_5_2_Вариант_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double F = 0;
            Console.WriteLine("Введите X");
            double x = Convert.ToDouble(Console.ReadLine());
            if (x < 13)
            {
                F = -Math.Pow(x,2)-9;
                Console.WriteLine("Ответ = " + F);
            }
            else
            {
                Console.WriteLine("ERROR");
            }

            if (x >= 13 - (1 / (Math.Pow(x, 2) + 9)))
            {
                F = -Math.Pow(x, 2) - 9;
                Console.WriteLine("Ответ = " + F);
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
