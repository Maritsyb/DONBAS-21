using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_4_4_Вариант_12
{
    internal class Program
    {
        class Book
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Список книг: Метро - 900руб, Война и мир - 1500руб, Мёртвые души - 700руб");
            Console.WriteLine("Ведите стоимость книги");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a == 900 || a == 1500 || a == 700)
            {
                Console.WriteLine("Введите сумму денег");
                double b = Convert.ToDouble(Console.ReadLine());
                if (b == a)
                {
                    Console.WriteLine("Спасибо за покупку! Приятного чтения!");
                }  
                else if (b > a)
                {
                    Console.Write("Спасибо за покупку! Получите сдачу в размере ");
                    Console.Write(b-a);
                    Console.WriteLine(" рублей.");
                }
                else if (b < a)
                {
                    Console.Write("Сумма денег меньше, цены книги, не хватает ");
                    Console.Write(a - b);
                    Console.WriteLine(" рублей.");
                }
            }
            else
            {
                Console.WriteLine("Такой цены нету в списке книг");
            }
        }
    }
}
