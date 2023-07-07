

public class Order
{
    private Customer customer;
    private Product[] products;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new Product[0];
    }

    public void AddProduct(Product product)
    {
        Array.Resize(ref products, products.Length + 1);
        products[products.Length - 1] = product;
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in products)
        {
            totalCost += product.GetPrice();
        }

        decimal shippingCost = customer.IsUSA() ? 5 : 35;
        return totalCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in products)
        {
            packingLabel += $"Product Name: {product.GetName()}, ID: {product.GetProductId()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Cliente Name: {customer.GetName()}\nAddress: {customer.GetAddress()}";
    }
}