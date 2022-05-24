// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте");
            Console.WriteLine("Введите число");
            int i = 0;
            if (int.TryParse(Console.ReadLine(), out i) == false)
            {
                Console.WriteLine("Введено недопустимое значение.");
                return;
            }
            Console.WriteLine("Последняя цифра квадрата этого числа = " + (Math.Pow((i % 10), 2) % 10));
            Console.WriteLine("Конец");
        }
    }
}
