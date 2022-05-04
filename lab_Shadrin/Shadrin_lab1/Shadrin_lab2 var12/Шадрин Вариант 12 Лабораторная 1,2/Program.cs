using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шадрин_Вариант_12_Лабораторная_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Радиус = ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Высота = ");
            double h = Convert.ToDouble(Console.ReadLine());
            double P = Convert.ToDouble(Math.PI * r * r * h * 1 / 3 * Math.PI * r * r * h);
            Console.WriteLine("Ответ = " + P);
        }
    }
}
