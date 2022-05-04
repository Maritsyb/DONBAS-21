using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_9_Шадрин
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов: ");

            int N = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Введите элементы через enter: ");

            List<int> numbers = new List<int>();

            for (int i = 0; i < N; ++i)
            {
                int temp = Convert.ToInt32(Console.ReadLine());
                numbers.Add(temp);
            }

            Console.WriteLine("Элемены значения которых совпадают с их индексом:");
            for (int i = 0; i < N; ++i)
            {
                if (numbers[i] == i)
                    Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
