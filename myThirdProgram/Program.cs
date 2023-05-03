using System;

namespace myThirdProgram
{
    class Program03
    {

        static void Main(string[] args)
        {
            int input;
            string guess = string.Empty;
        
            Console.Write("What is the magic number? ");
            string response = Console.ReadLine() ?? string.Empty;

            
            while (guess != response)
            {
                Console.Write("What is your guess? ");
                guess = Console.ReadLine() ?? string.Empty;

                if (int.TryParse(guess, out input))
                {
                if (input > int.Parse(response))
                {
                    Console.WriteLine("Lower");
                }
                else if (input < int.Parse(response))
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
