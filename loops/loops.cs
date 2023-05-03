using System;

namespace Loops
{
    class MagicNumber
    {
        static void Main(string[] args)
        {
            int number;
            string guess = string.Empty;

            Console.Write("Type a magic number: ");
            string input1 = Console.ReadLine() ?? string.Empty;
            
            while (guess != input1)
            {
                Console.Write("What is your guess? ");
                guess = Console.ReadLine() ?? string.Empty;

                if (int.TryParse(guess, out number))
                {
                    if (number > int.Parse(input1))
                    {
                        Console.WriteLine("Lower");
                    }
                    else if (number < int.Parse(input1))
                    {
                        Console.WriteLine("Higher");
                    }
                    else
                    {
                       Console.WriteLine("You guessed it!");
                    }
                }
            }
        }
    }
}