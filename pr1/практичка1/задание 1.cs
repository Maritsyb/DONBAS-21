// See https://aka.ms/new-console-template for more information
Console.WriteLine("Добро пожаловать");
Console.WriteLine("Вычислим площадь и пириметр прямогольного треугольника");
Console.WriteLine("Введите значение 'a' и нажмите enter");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение 'b' и нажмите enter");
double b = double.Parse(Console.ReadLine());
double p = a + b + Math.Sqrt(a * a + b * b);
double s = a * b / 2.0;
Console.WriteLine("Периметр равен " + p);
Console.WriteLine("Площадь равна " + s);
