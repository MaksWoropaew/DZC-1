// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
           // if ((number / 10 > 0) && (number / 100 ==0));

            int lastnum = number % 10;
            Console.WriteLine($"Цифра : {lastnum}");

        }
    }
}