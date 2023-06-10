using System;

namespace Program;

public class Program
{
    public static void Menu()
    {
        string menuOptions = 
        @"
        Menu Options:
            1. Start breathing activity
            2. Start reflecting activity
            3. Start listing activity
            4. Quit
        Select a choice from the menu: ";
        Console.Write(menuOptions); 
    }
         public static void Main()
    {
        while (true)
        {
            Menu();
            string entry = Console.ReadLine();


            if (entry == "1")
            {
                BreathingSession breathingSession = new BreathingSession();
                breathingSession.Start();
            }
            else if (entry == "2")
            {
                ReflectionSession reflectionSession = new ReflectionSession();
                reflectionSession.Start();
            }
            else if (entry == "3")
            {
                ListingSession listingSession = new ListingSession();
                listingSession.Start();
            }
            else if (entry == "4")
            {
                Console.WriteLine("Exiting...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            Console.WriteLine();
        }
    }
}