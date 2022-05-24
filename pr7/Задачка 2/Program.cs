// See https://aka.ms/new-console-template for more information
Console.WriteLine("Здравствуйте");
double sin = 0;
double sum = 0;
Console.WriteLine("Введите N ");
int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    sin += Math.Sin(N);
    sum += 1 / sin;
}

Console.WriteLine(sum);
Console.WriteLine("Конец");