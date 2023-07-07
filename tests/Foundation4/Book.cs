public class Book : Product
{
    public Book()
    {
        Description = "Book";
        Price = 19.99m;
    }

    public override decimal CalculatePrice()
    {
        return Price;
    }
}
