// See https://aka.ms/new-console-template for more information
      using System;
static void Main(string[] args)
{

    string s = string.Empty;
    int? min = null;
    while (true)
    {
        Console.WriteLine("Введите число, для окончания ввода дважды нажмите <Enter>:");
        Console.WriteLine();
        s = Console.ReadLine();
        int input;
        if (s == string.Empty) break;
        if (!int.TryParse(s, out input))
            Console.WriteLine("Число введено неправильно");
        else
            min = (min == null || min.Value > input) ? input : min;
    }
    Console.WriteLine($"Минимальное число из введённой последовательности: {min}");

    Console.ReadKey();
}