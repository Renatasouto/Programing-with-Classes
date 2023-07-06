public class Electronic : Product
{
    public Electronic()
    {
        Description = "Electronic";
        Price = 499.99m;
    }

    public override decimal CalculatePrice()
    {
        return Price;
    }
}