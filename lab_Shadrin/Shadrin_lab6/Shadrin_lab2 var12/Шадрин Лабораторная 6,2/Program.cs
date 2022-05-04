using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шадрин_Лабораторная_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа передвежения робота");
            Console.WriteLine("Стороны света: 1 - Север, 2 - Юг, 3 - Запад, 4 - Восток");
            Console.WriteLine("Выберите сторону света для движения робота");
            int C = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите действие для робота");
            Console.WriteLine("Действия: 0 - Продожить движение, 1 - Повернуть налево, 2 - Повернуть направо");
            Console.Write("Первое действие - ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Первое действие - ");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.Write("Первое действие - ");
            int B = Convert.ToInt32(Console.ReadLine());
            switch (C)
            {
                case 1:
                    Console.WriteLine("Робот будет двигается на Север");
                    break;
                case 2:
                    Console.WriteLine("Робот будет двигается на Юг");
                    break;
                case 3:
                    Console.WriteLine("Робот будет двигается на Запад");
                    break;
                case 4:
                    Console.WriteLine("Робот будет двигается на Восток");
                    break;
                default:
                    Console.WriteLine("Ого вы что открыли новую сторону света? А,нет.Вы просто не правильно ввели данные.");
                    break;
            }
            switch (N)
            {
                case 0:
                    Console.Write("Робот дивается вперёд, Продожить движение, ");
                    break;
                case 1:
                    Console.Write("Робот дивается вперёд, Повернуть налево, ");
                    break;
                case 2:
                    Console.Write("Робот дивается вперёд, Повернуть направо, ");
                    break;
                default:
                    Console.Write("Неверно заданное значение");
                    break;
            }
            switch (M)
            {
                case 0:
                    Console.Write("Продожить движение, ");
                    break;
                case 1:
                    Console.Write("Повернуть налево, ");
                    break;
                case 2:
                    Console.Write("Повернуть направо, ");
                    break;
                default:
                    Console.Write("Неверно заданное значение, ");
                    break;
            }
            switch (B)
            {
                case 0:
                    Console.WriteLine("Продожить движение ");
                    break;
                case 1:
                    Console.WriteLine("Повернуть налево ");
                    break;
                case 2:
                    Console.WriteLine("Повернуть направо ");
                    break;
                default:
                    Console.WriteLine("Неверно заданное значение");
                    break;
            }
            Console.WriteLine("Поздравлям вы привели робота домой!");
        }
    }
}
