using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_4_2_Вариант_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую переменную");
            double a =Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Введите Вторую переменную");
            double b = Convert.ToDouble(Console.ReadLine());
            
            if (a + b > 31676)
            {
                Console.WriteLine("ПЕРЕПОЛНЕНИЕ!!!");
            }
            else
            {
                Console.Write("Ответ = ");
                Console.WriteLine(a + b);
            }
        }
    }
}
