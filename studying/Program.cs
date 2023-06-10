using System;

namespace Program;

class Program
{
    static void Main(string[] args)
    {
        Body body = new Body();
        Head head = new Head();
        head.SetValue("Cabeca");
        body.SetHead(head);
        Console.WriteLine(body.GetHead().GetValue());
    }
}