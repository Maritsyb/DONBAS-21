using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шадрин_Лабораторная_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сотни.");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите десятки или числа от 11 до 19.");
            int с = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите единицы. ");
            int b = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Console.Write("Сто ");
                    break;
                case 2:
                    Console.Write("Двести ");
                    break;
                case 3:
                    Console.Write("Триста ");
                    break;
                case 4:
                    Console.Write("Четыреста ");
                    break;
                case 5:
                    Console.Write("Пятьсот ");
                    break;
                case 6:
                    Console.Write("Шестьсот ");
                    break;
                case 7:
                    Console.Write("Семьсот ");
                    break;
                case 8:
                    Console.Write("Восемьсот ");
                    break;
                case 9:
                    Console.Write("Девятьсот ");
                    break;
                default:
                    Console.Write(" ");
                    break;
            }
            switch (с)
            {
                case 1:
                    Console.Write("десять ");
                    break;
                case 2:
                    Console.Write("двадцать ");
                    break;
                case 3:
                    Console.Write("тридцать ");
                    break;
                case 4:
                    Console.Write("сорок ");
                    break;
                case 5:
                    Console.Write("пятьдесят ");
                    break;
                case 6:
                    Console.Write("шестьдесят ");
                    break;
                case 7:
                    Console.Write("семьдесят ");
                    break;
                case 8:
                    Console.Write("восемьдесят ");
                    break;
                case 9:
                    Console.Write("девяносто ");
                    break;  
                case 11:
                    Console.Write("одиннадцать ");
                    break;
                case 12:
                    Console.Write("двенадцать ");
                    break;
                case 13:
                    Console.Write("тринадцать ");
                    break;
                case 14:
                    Console.Write("четырнадцать ");
                    break;
                case 15:
                    Console.Write("пятнадцать ");
                    break;
                case 16:
                    Console.Write("шестнадцать ");
                    break;
                case 17:
                    Console.Write("семнадцать ");
                    break;
                case 18:
                    Console.Write("восемнадцать ");
                    break;
                case 19:
                    Console.Write("девятнадцать ");
                    break;
                default:
                    Console.Write(" ");
                    break;
            }
            switch (b)
            {
                case 1:
                    Console.WriteLine("один");
                    break;
                case 2:
                    Console.WriteLine("два");
                    break;
                case 3:
                    Console.WriteLine("три");
                    break;
                case 4:
                    Console.WriteLine("четыре");
                    break;
                case 5:
                    Console.WriteLine("пять");
                    break;
                case 6:
                    Console.WriteLine("шесть");
                    break;
                case 7:
                    Console.WriteLine("семь");
                    break;
                case 8:
                    Console.WriteLine("восемь");
                    break;
                case 9:
                    Console.WriteLine("девять");
                    break;
                default:
                    Console.WriteLine(" ");
                    break;
            }
            
        }
    }
}
