public class Cart
{
    private List<Product> productList;

    public Cart()
    {
        productList = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        productList.Add(product);
    }

    public void DisplayCartInfo()
    {
        foreach (Product product in productList)
        {
            Console.WriteLine($"Product: {product.Description} - Price: {product.Price:C}");
        }
    }

    public decimal CalculateTotalSale()
    {
        decimal totalSale = 0.0m;
        foreach (Product product in productList)
        {
            totalSale += product.CalculatePrice();
        }
        return totalSale;
    }
}