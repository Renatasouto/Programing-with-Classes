using System;
using System.Threading;

public class ListingSession : CalmnessSession
{
    private int itemCount; 

    public ListingSession()
    {
        Name = "\nListing Activity";
        Description = "\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void Start()
    {
        DisplayMessage($"{Name}\n{Description}");
        int duration = GetDuration();
        DisplayMessage("\nGet ready...\n");
        Thread.Sleep(2000);

        PerformListing(duration);

        DisplayMessage($"\nYou listed {itemCount} items!\n");
        

        DisplayMessage("\nWell Done!!\n");


        DisplayMessage($"\nYou have completed another {duration} seconds of the Listing activity");
        

        DisplayMessage("\nPress any key twice to return to the menu.");
        

        AnimateProgress();

        Console.ReadKey(true);
        Console.ReadKey(true);
        Console.Clear();
    }

    public void PerformListing(int duration)
{
    string[] prompts =
    {
        " --- Who are people that you appreciate? --- ",
        " --- What are personal strengths of yours? --- ",
        " --- Who are people that you have helped this week? --- ",
        " --- When have you felt the Holy Ghost this month? --- ",
        " --- Who are some of your personal heroes? --- "
    };
    Console.WriteLine("List as many responses you can to the following prompt: ");
    string prompt = prompts[new Random().Next(prompts.Length)];
    DisplayMessage(prompt);
    Console.Write("You may begin in: ");
    DisplayCountdownTimer(5);

    List<string> items = new List<string>(); // Lista para armazenar os itens inseridos

    DateTime startTime = DateTime.Now;
    while ((DateTime.Now - startTime).TotalSeconds < duration && items.Count < 4)
    {   Console.Write("\n> ");
        string item = Console.ReadLine();
        items.Add(item);
        itemCount++;
    }
}

    private void AnimateProgress()
    {
        char[] spinner = { '|', '/', '-', '\\' };
        int spinnerIndex = 0;

        while (!Console.KeyAvailable)
        {
            Console.Write(spinner[spinnerIndex]);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
            Thread.Sleep(1000);
        }

        Console.Clear();
    }

    private void WaitForEnter()
    {
        DisplayMessage("\nPress Enter to continue...");
        while (Console.ReadKey(true).Key != ConsoleKey.Enter)
        {
        
        }
    }

    private void DisplayCountdownTimer(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
        }
        Console.Write("  ");
        Console.SetCursorPosition(Console.CursorLeft - 2, Console.CursorTop);
    }

    private void DisplayCountdownTimer()
    {   
        int seconds = 5; 
        char[] spinner = { '|', '/', '-', '\\' };
        int spinnerIndex = 0;

        for (int i = seconds; i >= 0; i--)
        {
            Console.Write(spinner[spinnerIndex]);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
            Thread.Sleep(1000);
        }
    }

    private void DisplayMessageWithCursorAnimation(string message, int seconds)
    {
        Console.Write(message + " ");
        int cursorLeft = Console.CursorLeft; 

        char[] spinner = { '|', '/', '-', '\\' };
        int spinnerIndex = 0;

        for (int i = seconds; i >= 0; i--)
        {
            Console.Write(spinner[spinnerIndex]);
            Console.SetCursorPosition(cursorLeft, Console.CursorTop); 
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
            Thread.Sleep(1000);
        }

        Console.WriteLine(); 
        
    }
}

