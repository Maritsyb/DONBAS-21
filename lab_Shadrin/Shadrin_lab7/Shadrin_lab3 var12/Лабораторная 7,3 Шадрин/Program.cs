using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_7_3_Шадрин
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double F;
            for (double i = 0.1; i < 10; i++)
            {
                F = (1 + Math.Sin(i));
                Console.WriteLine("Ответ = " + F);
            }
        }
    }
}
