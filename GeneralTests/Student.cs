using System;

namespace GeneralTests
{
    class Student
    {
        static void Main(string[] args)
        {
            Console.Write("What is your percentage? ");
            string percentage = Console.ReadLine() ?? string.Empty;

            if (int.TryParse(percentage, out int secondpercentage))
            {
                if (secondpercentage >= 90)
                {
                    Console.WriteLine("your grade is A");
                }
                else if (secondpercentage >= 80)
                {
                    Console.WriteLine("your grade is B");
                }
                else if (secondpercentage >= 70)
                {
                    Console.WriteLine("your grade is C");
                }
                else if (secondpercentage >= 60)
                {
                    Console.WriteLine("your grade is D");
                }
                else
                {
                    Console.WriteLine("your grade is F");
                }
            }
        }
    }
}