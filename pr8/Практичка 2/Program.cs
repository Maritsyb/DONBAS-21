// See https://aka.ms/new-console-template for more information
Console.WriteLine("Начало");
static void Main()
{
    
        int k;
    double s = 0;
    Console.WriteLine("vvedite K");
    k = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < k; i++)
    {
        s += 1 / Factorial(k - i);
    }
    Console.WriteLine(s);
    Console.ReadKey();
}
static int Factorial(int numb)
{
    int rec = 1;
    for (int i = 1; i <= numb; i++)
        rec = rec * i;
    return rec;
}
Console.WriteLine("Конец");