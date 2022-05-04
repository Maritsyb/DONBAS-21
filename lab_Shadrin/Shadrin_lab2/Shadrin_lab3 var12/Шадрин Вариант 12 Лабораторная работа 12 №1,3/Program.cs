using System;

namespace Шадрин_Вариант_12_Лабораторная_работа_12__1_3
{
    class Program
    {
        static void Main(string[] args)
        {
           const double x = 12;
            double S;
            S = 13 *Math.Pow(x,3) - 3 * Math.Pow(x, 2) + 4 * x - 2;
            Console.Write("Значение полинома при x=12 = ");
            Console.WriteLine(S);
        }
    }
}
