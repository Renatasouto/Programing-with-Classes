using System;

namespace Lists
{
    class DoingLists
    {
        static void Main(string[] args)
        {   
            int input;
            string input1 = string.Empty;
            
            List<int> randon = new List<int>();
            int sum = 0;

            while(input1 != default)
            
            {
                Console.Write("Type a number: ");
                input1 = Console.ReadLine() ?? string.Empty;

                if (int.TryParse(input1, out input))
                {
                    if (input == 0) 
                        {
                            break;
                        }

                    randon.Add(input);
                }

            }   

            Console.WriteLine("The list contains these values: ");
            foreach (int item in randon)
            {
                Console.WriteLine(item);
                sum += item;
            }
            double media = (double)sum / randon.Count;
            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine("The average is: " + media);
            int maxNumber = randon.Max();      
            Console.WriteLine($"The biggest number is {maxNumber}");
        }
    }
}

        
