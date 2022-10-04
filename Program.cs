// Напишите программу, которая на вход принимает число (N), на выходе показывает все четные числа от 1 до N.

using System;
class homework
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int m = int.Parse(Console.ReadLine());
        for (int i = 1; i <= m; i++)
        {
            if (i % 2 == 0) 
            {
                Console.Write(i + " ");
            }
        }
        Console.ReadKey();
    }
}

