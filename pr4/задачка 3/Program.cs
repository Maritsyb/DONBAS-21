// See https://aka.ms/new-console-template for more information
Console.WriteLine("Добро пожаловать");
Console.WriteLine("Введите значение 'a' и нажмите enter");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение 'b' и нажмите enter");
int b = int.Parse(Console.ReadLine());
if ( a+b>=180)
{
    Console.WriteLine($"Треугольник не возможен");
}
else if (a+b>=90)
{
    Console.WriteLine($"Прямоугольный треугольник");
}
else
{
    Console.WriteLine("Треугольник существует");
}
Console.WriteLine("Конец!");