using System;

namespace Шадрин_12_Вариант_Лабораторная_работа__2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую сторону = ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону = ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Площадь прямоугольника = ");
            int S = A * B;
            Console.Write(S);

        }
    }
}



