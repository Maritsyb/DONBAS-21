// See https://aka.ms/new-console-template for more information
Console.WriteLine("Добро пожаловать");
Console.WriteLine("Введите значение x");
double x = Double.Parse(Console.ReadLine());
double y = Math.Pow(x, 3) - 2 * Math.Pow(x, 2) + 4 * x - 2; //x^3 - 2*x^2 + 4*x -2
Console.WriteLine("значение полинома " + y);  