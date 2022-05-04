using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_3_2_Вариант_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите переменную x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите переменную y");
            double y = Convert.ToDouble(Console.ReadLine());
            double S = Math.Pow(3, x) - 4 * x + (y - Math.Sqrt(Math.Abs(x)));
            Console.WriteLine("Ответ = " + S);
        }
    }
}
