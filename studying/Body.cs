using System;

public class Body
{
    private Head head{get; set;}
    private Torso torso{get; set;}
    private List<Limbs> limbs{get; set;}

    public Body()
    {
    
    }

    public Head GetHead()
    {
        return head;
    }

    public void SetHead(Head value)
    {
        head = value;
    }

    public Torso GetTorso()
    {
        return torso;
    }

    public void SetTorso(Torso value)
    {
        torso = value;
    }

    public List<Limbs> GetLimbs()
    {
        return limbs;
    }

    public void SetLimbs(List<Limbs> value)
    {
        limbs = value;
    }

    public void Think()
    {
        Console.WriteLine("Thinking...");
    }
}