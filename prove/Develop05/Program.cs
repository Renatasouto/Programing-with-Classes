public class Program
{
    public static void Main(string[] args)
    {
        EternalQuestProgram questProgram = new EternalQuestProgram();

        while (true)
        {
            Console.WriteLine($"\nYou have {questProgram.GetScore()} points");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("\nThe types of goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                int goalType = Convert.ToInt32(Console.ReadLine());

                Console.Write("What is the name of your goal? ");
                string goalName = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                string goalDescription = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                int goalPoints = Convert.ToInt32(Console.ReadLine());

                

                Goal goal = null;
                if (goalType == 1)
                {
                    goal = new SimpleGoal(goalName, goalPoints, goalDescription);
                }
                else if (goalType == 2)
                {
                    goal = new EternalGoal(goalName, goalPoints, goalDescription);
                }
                else if (goalType == 3)
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int goalCompletionCount = Convert.ToInt32(Console.ReadLine());

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int goalBonus = Convert.ToInt32(Console.ReadLine());

                    goal = new ChecklistGoal(goalName, goalPoints, goalDescription, goalCompletionCount, goalBonus);
                }

                questProgram.CreateGoal(goal);
                Console.WriteLine("Goal created successfully.");
                Console.WriteLine();
            }
            else if (choice == 2)
            {
                questProgram.ShowGoals();
                Console.WriteLine();
            }
            else if (choice == 3)
            {

                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                questProgram.SaveGoals(filename);
                Console.WriteLine("Goals saved successfully.");
                Console.WriteLine();

            }
            else if (choice == 4)
            {

                Console.Write("What is the filename for the goal file? ");
                string filename = Console.ReadLine();
                questProgram.LoadData(filename);
                Console.WriteLine(); 
               
            }
            else if (choice == 5)
            {
                Console.Write("Enter the name of the goal: ");
                string goalName = Console.ReadLine();
                questProgram.RecordEvent(goalName);
                Console.WriteLine();
            }
            else if (choice == 6)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Console.WriteLine();
            }
        }

        Console.ReadLine();
    }
}