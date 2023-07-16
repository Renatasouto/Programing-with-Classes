public class Order
{
    private Customer _customer;
    private Product[] _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new Product[0];
    }

    public void AddProduct(Product product)
    {
        Array.Resize(ref _products, _products.Length + 1);
        _products[_products.Length - 1] = product;
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetPrice();
        }

        decimal shippingCost = _customer.IsUSA() ? 5 : 35;
        return totalCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"Product Name: {product.GetName()}, ID: {product.GetProductId()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Client Name: {_customer.GetName()}\nAddress: {_customer.GetAddress()}";
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    public Product[] GetProducts()
    {
        return _products;
    }

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public void SetProducts(Product[] products)
    {
        _products = products;
    }
}
