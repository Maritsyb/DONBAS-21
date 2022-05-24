// See https://aka.ms/new-console-template for more information
static void Main(string[] args)
{
    Console.Write("Начало");
    int sum = 0, rand = 0;
    int n = int.Parse(Console.ReadLine());
    var mas = new int[n];
    var random = new Random();

    Console.Write("Введите  K:");
    int k = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        rand = random.Next(0, 10);
        mas[i] = rand;

        if (mas[i] % k == 0)
            sum += mas[i];
    }
    Console.WriteLine(sum);
    Console.ReadKey();
    Console.Write("Конец");
}
