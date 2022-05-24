// See https://aka.ms/new-console-template for more information
Console.WriteLine("Добро пожаловать");
Console.WriteLine("Вычислим заработок мальчика");
Console.WriteLine("Введите значение 'a' за 15 газет и нажмите enter"); //сумма за первые 15 газет
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение 'x' за кждую следующую газету и нажмите enter"); //за каждую из следующих газет 
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите колличество 'b' газет продал мальчик и нажмите enter"); //число газет которое он продаст 
double b = double.Parse(Console.ReadLine());
double F = 15 * a; //за 15 газет
double G = (b - 15) * x; //за каждую из след.
double M = F + G;
Console.WriteLine("Мальчик заработал " + M);
Console.WriteLine("Конец!");

