using System;

namespace Шадрин_12_Вариант_Лабораторная_работа__2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            double B;
            double S;
            Console.WriteLine("Количество машин");
            A =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Цена");
            B = Convert.ToDouble(Console.ReadLine());
            S = A * B;
            Console.Write("Итог = ");
            Console.WriteLine(S);
        }
    }
}
