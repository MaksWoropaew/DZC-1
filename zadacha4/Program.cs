﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Четные числа :");
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                Console.Write(i);
            }
        }
    }
}









