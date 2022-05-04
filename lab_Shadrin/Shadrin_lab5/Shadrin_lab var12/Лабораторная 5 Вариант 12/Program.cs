using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_5_Вариант_12
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            double F = 0;
            Console.WriteLine("Введите X");
            double x = Convert.ToDouble(Console.ReadLine());
            if (x < 73)
            {   
                    F = -Math.Pow(x,2);
                    Console.WriteLine("Ответ = " + F);   
            }  
            else 
            {
                Console.WriteLine("ERROR");
            }
            
            if (x >= 7 * ((Math.Pow(2, -x)) / (Math.Pow(x, 2) - 9)))
            {
                F = -Math.Pow(x, 2);
                Console.WriteLine("Ответ = " + F);
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
