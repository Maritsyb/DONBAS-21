using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_7_Шадрин
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double F;
            Console.WriteLine("Введите a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите h");
            int h = Convert.ToInt32(Console.ReadLine());

            for (int x = a; x <= b; x += h)
            {
                F = Math.Tan(2 * x) - 3;
                Console.WriteLine("Ответ = " + F);
            }
        }
    }
}
