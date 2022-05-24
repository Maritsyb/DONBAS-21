// See https://aka.ms/new-console-template for more information
Console.WriteLine("Здравствуйте, Приятной работы!");
Console.WriteLine("Введите значение 'x' и нажмите enter");
double x = Double.Parse(Console.ReadLine());

double y = 1 - 2 * x + 3 * Math.Pow(x, 2) - 4 * Math.Pow(x, 3);

Console.WriteLine("1 - 2 * x + 3 = " + y);

y = 1 + 2 * x + 3 * Math.Pow(x, 2) + 4 * Math.Pow(x, 3);

Console.WriteLine("1 + 2 * x + 3 = " + y);

Console.WriteLine("Спасибо за работу!");
