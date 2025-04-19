using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть ціле число N:");
        int N = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i <= N; i++)
        {
            sum += i * i;
        }

        Console.WriteLine($"Сума квадратів чисел від 1 до {N} дорівнює: {sum}");
    }
}
