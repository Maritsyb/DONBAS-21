using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_3_Вариант_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x");
            double x = Convert.ToDouble(Console.ReadLine());
            double S = 2 * (1 / Math.Tan(3 * x)) - (Math.Log(Math.Cos(x)) / Math.Log(1 + Math.Pow(x, 2)));
            Console.WriteLine("Ответ = " + S);
        }
    }
}
