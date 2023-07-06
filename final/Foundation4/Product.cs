public abstract class Product
{
    public string Description { get; set; }
    public decimal Price { get; set; }
    public abstract decimal CalculatePrice();
}