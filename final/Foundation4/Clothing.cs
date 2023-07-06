public class Clothing : Product
{
    public Clothing()
    {
        Description = "Clothing";
        Price = 39.99m;
    }

    public override decimal CalculatePrice()
    {
        return Price;
    }
}

