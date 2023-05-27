using System;
using System.IO;
using System.Collections.Generic;

namespace Develop02
{
    class Program
    {
        Journal journal;

        static void Main(string[] args)
        {
            bool quit = false;
            Program program = new Program();

            while(!quit)
            {
                program.Menu();
                Console.Write("What would you like to do? ");
                string choice = Console.ReadLine() ?? "";
                switch(choice)
                {
                    case "1": 
                        string prompt = program.RandomPrompt();
                        Console.WriteLine(prompt);
                        string answer = Console.ReadLine() ?? "";
                        if (!string.IsNullOrEmpty(answer))
                        {
                            program.Write(prompt, answer);
                        }
                        else 
                        {
                            Console.WriteLine("Answer cannot be empty. Try again.");
                        }
                        break;
                    case "2": 
                        program.journal?.display();
                        break;
                    case "4": 
                        Console.Write("What is the filename? ");
                        string loadFilename = Console.ReadLine() ?? "";
                        if (!string.IsNullOrEmpty(loadFilename)) 
                        {
                            program.Load(loadFilename);
                        }
                        break;
                    case "3": 
                        Console.Write("What is the filename? ");
                        string saveFilename = Console.ReadLine() ?? "";

                         if (!string.IsNullOrEmpty(saveFilename)) 
                        {
                            program.Save(saveFilename + ".txt");
                        }
                        break;
                    case "5": 
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Please, choose a valid option.");
                        break;
                }
    
            }
        }

        public void Menu()
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine( "1. Write\n2. Display\n3. Save\n4. Load\n5. Quit");

        }

        public string RandomPrompt()
        {
            List<string> prompts = new List<string>() 
            {"What is one thing I learned today that I didn't know before?", 
            "What are three things I'm grateful for today and why?", 
            "Is there a situation or a person that has been on my mind lately? Why do I think that is?", 
            "What brought me joy today or this week? How can I incorporate more of that into my life?"};
            Random rnd = new Random();
            int indiceAleatorio = rnd.Next(prompts.Count);
            string elementoAleatorio = prompts[indiceAleatorio];

            return elementoAleatorio;
        }
        
        public void Write(string prompt, string answer)
        {
            if (journal == null)
            {
                journal = new Journal();
            }
            journal.AddEntry(new Entry(prompt, answer));
        }
        
        public void Load(string filename)
        {
            if (File.Exists(filename+".txt"))
            {
                journal = new Journal(); 
                using (StreamReader file = new StreamReader(filename+".txt"))
                {
                    string line = file.ReadLine() ?? "";
                   
                    while(line != null && line != "")
                    {
                        
                        string [] parts = line.Split(',');

                        if (parts.Length == 3)
                        {
                            Entry entry = new Entry(parts[0], parts[1],parts[2]);
                            journal.AddEntry(entry);
                        }
                          line = file.ReadLine() ?? "";
                    }
                }
            }
            else
            {
                Console.WriteLine($"The file {filename} does not exist.");
            }
        }

          public void Save(string filename)
        {
          
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry entry in journal?.GetEntries() ?? new List<Entry>())
                {
                    outputFile.WriteLine(entry.GetDate+","+entry.GetPrompt+","+entry.GetAnswer);
                }
            }       
          
        }

    }
}