using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_7_2_Шадрин
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите х");
            double x = Convert.ToDouble(Console.ReadLine());
            double F = 1.0;
            for (int i = 2; i <= 64; i *= 2)
            {
                F *= (x - 2 * i + 1)/(x - 2 * i);
                Console.WriteLine("Ответ = " + F);
            }
        }
    }
}
