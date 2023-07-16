using System;

public class Program
{
    public static void Main()
    {
        Address address1 = new Address
        {
            Street = "525 S Center St",
            City = "Rexburg",
            State = "ID",
            PostalCode = "83460"
        };

        Address address2 = new Address
        {
            Street = "1 Microsoft Way",
            City = "Redmond",
            State = "WA",
            PostalCode = "98052"
        };

        Address address3 = new Address
        {
            Street = "350 5th Ave",
            City = "New York",
            State = "NY",
            PostalCode = "10118"

        };

        Lecture lecture = new Lecture
        {
            Title = "BYU Idaho - Joseph Smith Amphitheater",
            Description = "The importance of Python for machine learning",
            Date = "2023-08-15",
            Time = "10:00 AM",
            Address = address1,
            Speaker = "Peter Burns",
            Capacity = 100 
        };

        Reception reception = new Reception
        {
            Title = "Networking Event",
            Description = "Networking and socializing",
            Date = "2023-08-20",
            Time = "6:00 PM",
            Address = address2,
            RsvpEmail = "networkingredmond@gmail.com"
        };

        OutdoorGathering outdoorGathering = new OutdoorGathering
        {
            Title = "Summer Picnic",
            Description = "Join us for a fun-filled summer picnic",
            Date = "2023-08-25",
            Time = "12:00 PM",
            Address = address3,
            Weather = "Sunny"
        };

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (Event evnt in events)
        {   
            Console.WriteLine("Program 3: Inheritance with Event Planning");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("- Standard Details");
            Console.WriteLine(evnt.GetStandardDetails());
            Console.WriteLine("\n - Full Details");
            Console.WriteLine(evnt.GetFullDetails());
            Console.WriteLine("\n - Short Description");
            Console.WriteLine(evnt.GetShortDescription());
        }
    }
}