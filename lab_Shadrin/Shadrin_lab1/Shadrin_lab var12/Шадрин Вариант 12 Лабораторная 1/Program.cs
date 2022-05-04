using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шадрин_Вариант_12_Лабораторная_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите певый угол");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ведите второй угол");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ведите третий угол");
            double C = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ведите Радиус");
            double R = Convert.ToDouble(Console.ReadLine());
            double a = Math.Pow(R, 2) * (2 + Math.Cos(A + B - C));
            Console.WriteLine("Ответ = " + a);
        }
    }
}
