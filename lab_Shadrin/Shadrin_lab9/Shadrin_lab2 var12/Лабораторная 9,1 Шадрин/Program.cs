using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабораторная_9_1_Шадрин
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a ={ 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 11, 12, 13, 14, 15 };
            int F(int n) => n < 2 ? 1 : F(n - 1) + F(n - 2);
            int s = 0;
            for (int i = 1, f = F(i); f < a.Length; i += 1, f = F(i))
                s += a[f];
            Console.WriteLine(s);
        }
    }
}
