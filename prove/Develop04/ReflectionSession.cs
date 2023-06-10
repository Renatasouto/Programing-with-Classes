using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionSession : CalmnessSession
{
    public ReflectionSession()
    {
        Name = "\nReflection Activity";
        Description = "\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public override void Start()
    {
        DisplayMessage($"{Name}\n{Description}");
        int duration = GetDuration();
        DisplayMessage("\nGet ready...\n");
        DisplayMessage("Consider the following prompt: \n");
        Thread.Sleep(2000);

        PerformReflection(duration);
    }

    public void PerformReflection(int duration)
    {
        string[] prompts =
        {
            "--- Think of a time when you stood up for someone else. ---",
            "--- Think of a time when you did something really difficult. ---",
            "--- Think of a time when you helped someone in need. ---",
            "--- Think of a time when you did something truly selfless. ---"
        };

        string[] questions =
        {
            " > Why was this experience meaningful to you?",
            " > Have you ever done anything like this before?",
            " > How did you get started?",
            " > How did you feel when it was complete?",
            " > What made this time different than other times when you were not as successful?",
            " > What is your favorite thing about this experience?",
            " > What could you learn from this experience that applies to other situations?",
            " > What did you learn about yourself through this experience?",
            " > How can you keep this experience in mind in the future?"
        };

        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            string prompt = prompts[new Random().Next(prompts.Length)];
            DisplayMessage(prompt);
            WaitForEnter();

            DisplayMessage("\nNow ponder on each of the following questions as they relate to this experience.\n");

            Console.Write("You may begin in: ");
            DisplayCountdownTimer(5);


            Console.Clear();

            List<string> randomQuestions = GetRandomQuestions(questions, 2);

            DisplayMessageWithCursorAnimation(randomQuestions[0], 10);

            DisplayMessageWithCursorAnimation(randomQuestions[1], 10);

            DisplayMessage("\nWell done!");

            Console.Write($"\nYou have completed another {duration} seconds of the Reflection Activity. ");

            DisplayMessage("\nPress any key twice to return to the menu.");

            AnimateProgress();

            Console.ReadKey(true);
            Console.ReadKey(true);
            Console.Clear();
        }
    }

    private void WaitForEnter()
    {
        DisplayMessage("\nWhen you have something in mind, press enter to continue.");
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

    private void DisplayMessageWithTimer(string message, int seconds)
    {
        Console.WriteLine(message);
        DisplayCountdownTimer(seconds);
        Console.WriteLine();
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

    private List<string> GetRandomQuestions(string[] questions, int count)
    {
        List<string> randomQuestions = new List<string>();
        Random random = new Random();

        while (randomQuestions.Count < count)
        {
            int index = random.Next(questions.Length);
            string question = questions[index];
            if (!randomQuestions.Contains(question))
                randomQuestions.Add(question);
        }

        return randomQuestions;
    }

    private void DisplayCountdownTimer()
    {   
        int seconds = 10; 
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
