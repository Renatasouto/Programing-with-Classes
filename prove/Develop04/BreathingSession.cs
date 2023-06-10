public class BreathingSession : CalmnessSession
{
    public BreathingSession()
    {
        Name = "\nWelcome to the Breathing Activity\n";
        Description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n";
    }

    public override void Start()
    {
        DisplayMessage($"{Name}\n{Description}");
        int duration = GetDuration();
        DisplayMessage("\nGet ready...\n");
        Thread.Sleep(2000);

        PerformBreathing(duration);
    }

    public void PerformBreathing(int duration)
    {
        string[] breaths = { "Breath in...", "Now breath out..." };
        int secondsPerLine = 5;
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            for (int i = 0; i < breaths.Length; i++)
            {
                Console.Write($"{breaths[i]} ");

                int secondsCount = secondsPerLine;
                while (secondsCount > 0 && (DateTime.Now - startTime).TotalSeconds < duration)
                {
                    Console.SetCursorPosition(breaths[i].Length + 1, Console.CursorTop);
                    Console.Write($"{secondsCount%10}");
                    secondsCount--;

                    Thread.Sleep(1000);
                }

                Console.SetCursorPosition(breaths[i].Length + 1, Console.CursorTop);
                Console.Write(" ");

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        Console.WriteLine("Well done!");
        Console.WriteLine($"\nYou have completed another {duration} seconds of the Breathing Activity.");
        Console.WriteLine("Double press any key to return to the menu.");

        AnimateProgress();

        Console.ReadKey(true);
        Console.Clear();
    }

    private void AnimateProgress()
    {
        char[] spinner = { '|', '/', '-', '\\' };
        int spinnerIndex = 0;
        DateTime startTime = DateTime.Now;

        while (!Console.KeyAvailable)
        {
            Console.Write(spinner[spinnerIndex]);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
            Thread.Sleep(200);
        }

        Console.ReadKey(true);
        Console.Clear();
    }
}
