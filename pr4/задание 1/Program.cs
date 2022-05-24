// See https://aka.ms/new-console-template for more information
namespace X
{
    class Program
    {
        delegate double del(double x);
        static void Main(string[] args)
        {
            del myDel = x => x >= 0 ? Math.Pow(x, 2) : Math.Pow(x, 4);
            Console.WriteLine("Добро пожаловать");
            Console.WriteLine("Введите три числа через пробел  и нажмите enter");
            string[] numbers = Console.ReadLine().Split(' ');
            double A = double.Parse(numbers[0]);
            double B = double.Parse(numbers[1]);
            double C = double.Parse(numbers[2]);

            Console.WriteLine("{0} {1} {2}", myDel(A) , myDel(B) , myDel(C));

            Console.ReadKey();
            Console.WriteLine("Конец!");
        }
    }
}
