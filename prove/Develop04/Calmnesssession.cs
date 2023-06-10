using System;
using System.Threading;

public abstract class CalmnessSession
{
    public string Name { get; set; }
    public string Description { get; set; }

    public void DisplayMessage(string message)
    {
        Console.WriteLine(message);
        Thread.Sleep(2000);
    }

    public void PauseWithSpinner(int duration)
    {
        string[] spinners = { "-", "\\", "|", "/" };
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            foreach (string spinner in spinners)
            {
                Console.Write(spinner + "\r");
                Thread.Sleep(100);
            }
        }
    }

    public abstract void Start();

    public int GetDuration()
    {
        Console.Write("\nHow long, in seconds, would you like for your session?  ");
        return Convert.ToInt32(Console.ReadLine());
    }
}
