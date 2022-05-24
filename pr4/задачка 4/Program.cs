// See https://aka.ms/new-console-template for more information
Console.WriteLine("Добро пожаловать");
Console.WriteLine("Введите значение 'x' и нажмите enter");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение 'y' и нажмите enter");
int y = int.Parse(Console.ReadLine());
int S = (x+y)/2;
int P = (x*y)*2;
if (x < y)
{
    Console.WriteLine($"x = {S} y = {P}");
}
else if (y < x)
{
    Console.WriteLine($"x = {P} y = {S}");
}
else
{
    Console.WriteLine("ошибка");
}
Console.WriteLine("Конец!");
