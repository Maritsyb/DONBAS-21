// See https://aka.ms/new-console-template for more information
Console.WriteLine("Здравствуйте");
double cos = 0;
double P = 0;
Console.WriteLine("Введите N ");
int N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    cos += Math.Cos(N);
    P += 1 / cos;
}
Console.WriteLine(P);
Console.WriteLine("Конец");
