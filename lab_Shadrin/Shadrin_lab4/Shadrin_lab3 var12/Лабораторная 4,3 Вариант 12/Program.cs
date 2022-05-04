using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_4_3_Вариант_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пароль");
            double a = Convert.ToDouble(Console.ReadLine());
            //модуль А 1
            if (a == 9583 || a == 1747)
            {
                Console.WriteLine("Доступ к модулям А открыт");                
            }
            else
            {
                Console.WriteLine("Доступ закрыт!");
            }
            //модуль В 1
            if (a == 3331 || a == 7922)
            {
                Console.WriteLine("Доступ к модулям В открыт");
            }
            else
            {
                Console.WriteLine("Доступ закрыт!");
            }
            //модуль С 1
            if (a == 9455 || a == 8997)
            {
                Console.WriteLine("Доступ к модулям С открыт");
            }
            else
            {
                Console.WriteLine("Доступ закрыт!");
            } 
        }
    }
}
