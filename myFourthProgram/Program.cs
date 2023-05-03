using System;
using System.Collections.Generic;

namespace MyFourthProgram
{
    class Program04
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int inputNumber;

            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

            do
            {
                Console.Write("Enter a number: ");
                inputNumber = int.Parse(Console.ReadLine());
                numbers.Add(inputNumber);
            } while (inputNumber != 0);

            int sum = 0;
            int max = int.MinValue;

            foreach (int number in numbers)
            {
                sum += number;
                if (number > max)
                {
                    max = number;
                }
            }

            double average = (double)sum / (numbers.Count - 1);

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");
        }
    }
}