using System;

namespace meuPirmeiroPrograma
{
    class Program02
    {
        static void Main(string[] args)
        {
            Console.Write("What is your  grade percentage? ");
            string userInput = Console.ReadLine() ?? string.Empty;

            if (int.TryParse(userInput, out int percentage))
            {
                if (percentage >= 90)
                {
                    Console.WriteLine("Yor grade is A");
                }
                else if (percentage >= 80)
                {
                    Console.WriteLine("Yor grade is B");
                }
                else if (percentage >= 70)
                {
                    Console.WriteLine("Yor grade is C");
                }
                else if (percentage >= 60)
                {
                    Console.WriteLine("Yor grade is D");
                }
                else
                {
                    Console.WriteLine("Yor grade is F");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}