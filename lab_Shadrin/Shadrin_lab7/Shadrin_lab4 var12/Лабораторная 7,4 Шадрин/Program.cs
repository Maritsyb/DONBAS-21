using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_7_4_Шадрин
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите X");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число шагов");
            double n = Convert.ToInt32(Console.ReadLine());
            double F = 0;
            for (int i = 1; i <= n; ++i) 
            { 
                F += Math.Pow(Math.Sin(x), i);
                Console.WriteLine("Ответ = " + F);
            }
        }
    }
}
