// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            //var variable = Console.ReadLine();
            //var result = int.TryParse(string.Join("",variable.Where(x=>char.IsDigit(x))), out int n);
            //Console.WriteLine(n);
            string value = Convert.ToString(Console.ReadLine());
            int number = Convert.ToInt32(value);
            if (number / 100 > 0)
            {
                int lastnum = number % 10;
                Console.WriteLine($"Цифра : {lastnum}");
            }
            else
                Console.WriteLine("Число не трехзначное");
        }
    }
}