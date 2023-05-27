using System;

namespace Develop02
{
    class Entry
    {
        string Date;
        string Prompt;
        string Answer;

        public Entry(string prompt, string answer)
        {
            Date = DateTime.UtcNow.ToString("MM-dd-yyyy");
            Prompt = prompt;
            Answer = answer;
        }

         public Entry(string date, string prompt, string answer)
        {
            Date = date;
            Prompt = prompt;
            Answer = answer;
        }

        public override string ToString()
        {
            return "Date: " + Date + " - Prompt: " + Prompt + "\r\n" + Answer;
        }

         public string GetDate
    {
        get { return Date; }
    }

     public string GetPrompt
    {
        get { return Prompt; }
    }

     public string GetAnswer
    {
        get { return Answer; }
    }
    }
}