
// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp11

{
    class Program

    {
        static void Main(string[] args)
        {
            Console.Write("Здравствуйте");
            Console.Write("Введите N: ");
            int N = int.Parse(Console.ReadLine());
            double S = 0;
            for (int i = 0; i < N; i++)
            S += Math.Pow(-1, i) * (1 / Math.Pow(2, i));
            Console.WriteLine("Ответ: " + S);
            Console.ReadKey();
            Console.Write("Конец");
        }
    }
}