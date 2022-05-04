using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_10_Шадрин
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Метод вычисления уравнений");
            double b = Convert.ToInt32(Console.ReadLine());
            void Sum1(double a)
            {
                double result = a * 2;
                Console.WriteLine("y = " + result);
                result = Math.Sqrt(a);
                Console.WriteLine("y = " + result);
            }
            Sum1(b) ;
            
            Console.WriteLine("Таблица значений от -10 до 10 с шагом 1");
            int i = -11;
            while( i < 10)
            {
                i++;
                Console.WriteLine(i);
            }
        }
        
    }
}
