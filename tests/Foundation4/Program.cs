using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Product book = new Book();
        Product electronic = new Electronic();
        Product clothing = new Clothing();

        Cart cart = new Cart();
        cart.AddProduct(book);
        cart.AddProduct(electronic);
        cart.AddProduct(clothing);

        cart.DisplayCartInfo();

        decimal totalSale = cart.CalculateTotalSale();
        Console.WriteLine($"Total Sale Amount: {totalSale:C}");
    }
}