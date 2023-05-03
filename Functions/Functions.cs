
using System;

namespace Function
{
    class LearningFunctions
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num1 = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Enter a number: ");
            int num2 = int.Parse(Console.ReadLine() ?? "0");

            int sum = Add(num1, num2);
            Console.WriteLine($"The sum of {num1} and {num2} is: {sum}.");
                
            int diff = Subtract(num1, num2);
            Console.WriteLine($"The difference between {num1} and {num2} is {diff}. ");

        }
        static int ParseInput(string input)
        {
            return int.TryParse(input, out int num) ? num : 0;
        }
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
    }   
}
