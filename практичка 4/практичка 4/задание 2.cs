// See https://aka.ms/new-console-template for more information
Console.WriteLine("Добро пожаловать");
Console.WriteLine("Введите значение 'x1' и нажмите enter");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение 'y1' и нажмите enter");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение 'x2' и нажмите enter");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение 'y2' и нажмите enter");
int y2 = int.Parse(Console.ReadLine());
 int num1 =((x1*x1)+(y1*y1));
int num2 = ((x2*x2)+(y2*y2));
if (num1 > num2)
{
    Console.WriteLine($"точка {num1} дальше точки {num2}");
}
else if (num1 < num2)
{
    Console.WriteLine($"точка {num2} дальше точки {num1}");
}
else
{
    Console.WriteLine("точки с равными координатами");
}
Console.WriteLine("Конец!");