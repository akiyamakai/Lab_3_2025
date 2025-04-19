using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть елементи масиву через пробіл:");
        string input = Console.ReadLine();

        double[] array = input.Split(' ').Select(double.Parse).ToArray();

        if (array.Length == 0)
        {
            Console.WriteLine("Масив порожній!");
            return;
        }

        double average = array.Average();

        int count = array.Count(x => x > average);

        Console.WriteLine($"Середнє арифметичне: {average}");
        Console.WriteLine($"Кількість елементів, більших за середнє: {count}");
    }
}