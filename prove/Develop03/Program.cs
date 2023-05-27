using System;

namespace Program;

public class Program
{
    private static Scripture _scripture;

    public static void Main(string[] args)
    {
        RunProgram();
    }

    public static void RunProgram()
    {
        // Define the scripture reference
        var reference = new ScriptureReference("John", 3, 16);

        // Define the scripture text
        var wordsText = "And other sheep I have, which are not of this fold: them also I must bring, and they shall hear my voice; and there shall be one fold, and one shepherd.";
        var words = wordsText.Split(' ').Select(w => new Word(w)).ToList();

        // Create the scripture
        _scripture = new Scripture(reference, words);

        // Loop until user types "quit" or all words are hidden
        while (true)
        {
            DisplayScripture();

            // Check if there are any words left to hide
            if (!_scripture.GetWords().Any(w => !w.GetIsHidden()))
                break;

            var userInput = GetUserInput();

            // If user typed "quit", break the loop
            if (userInput.ToLower() == "quit")
                break;

            HideRandomWord();
        }
    }

    private static void DisplayScripture()
    {
        // Clear the console and display the scripture
        Console.Clear();
        Console.WriteLine(_scripture.DisplayScripture());
    }

    private static void HideRandomWord()
    {
        // Hide a random word
        _scripture.HideRandomWord();
    }

    private static string GetUserInput()
    {
        // Prompt for user input
        Console.WriteLine("\nPress enter to continue or type `quit` to finish");
        return Console.ReadLine();
    }
}
