// See https://aka.ms/new-console-template for more information
Console.WriteLine("Добро пожаловать");
Console.WriteLine("Введите значение 'a' и нажмите enter");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение 'b' и нажмите enter");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение 'c' и нажмите enter");
double c = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение 'd' и нажмите enter");
double d = double.Parse(Console.ReadLine());
double U = ((b + Math.Pow((Math.Pow(b, 2) + 4 * a * c), 1 / 2)) / (2 * a)) - Math.Pow(a, 3) * c + Math.Pow(b, -2);
double Y = (((a / c) * (b / d)) - (a * b - c)) / (c * d);
Console.WriteLine("По первой формуле " + U);
Console.WriteLine("По второй формуле " + Y);
Console.WriteLine("Конец!");
