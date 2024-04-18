using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<double> numbers = new List<double>();

        Console.WriteLine("Введите вещественные числа (для завершения введите 10):");
        FillArray(numbers);

        double sumOfNegatives = SumOfNegativeElements(numbers);

        Console.WriteLine($"Сумма отрицательных элементов массива: {sumOfNegatives}");
    }

    static void FillArray(List<double> array)
    {
        double input;
        while ((input = Convert.ToDouble(Console.ReadLine())) != 10)
        {
            array.Add(input);
        }
    }

    static double SumOfNegativeElements(List<double> array)
    {
        double sum = 0;
        foreach (double number in array)
        {
            if (number < 0)
            {
                sum += number;
            }
        }
        return sum;
    }
}
