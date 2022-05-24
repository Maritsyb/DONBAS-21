// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Здравствуйте");
                Console.WriteLine("Пожалуйста введите номер деня недели:");

                int x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.WriteLine("У нас сегодня 3 пары");
                        break;
                    case 2:
                        Console.WriteLine("У нас сегодня 2 пары");
                        break;
                    case 3:
                        Console.WriteLine("У нас сегодня нет пар");
                        break;
                    case 4:
                        Console.WriteLine("У нас сегодня 1 пара");
                        break;
                    case 5:
                        Console.WriteLine("У нас сегодня 1 пара");
                        break;
                    case 6:
                        Console.WriteLine("У нас сегодня 5 пар");
                        break;
                    case 7:
                        Console.WriteLine("У нас сегодня нет пар");
                        break;
                    default:
                        Console.WriteLine("Нет такого дня!");
                        break;
                     
                }
            }

        }
    }
 
}


