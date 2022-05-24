// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Здравствуйе");
        Console.WriteLine("Введите год: ");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите месяц");
        int month = int.Parse(Console.ReadLine());

        bool b = false; // Високосный год
        if (year % 4 == 0)
            b = true;

        int days = 0;

        if (month == 2)
        {
            if (b)
                days = 28;
            else
                days = 29;
        }
        else if (month > 0 & month < 8)
        {
            if (month % 2 == 0)
                days = 30;
            else
                days = 31;
        }
        else if (month >= 8 & month <= 12)
        {
            if (month % 2 == 0)
                days = 31;
            else
                days = 30;
        }
        else
            days = -1;

        if (days != -1)
            Console.WriteLine("Кол-во дней: {0}", days);
        else
            Console.WriteLine("Нет такого месяца");


        Console.ReadKey();
    }
}
