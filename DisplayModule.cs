using System;

class DisplayModule
{
    public static void displayProduct(Product product, double price)
    {
        Console.WriteLine($"Informations de {product.name} : {product.category}, {product.description}, {product.details}"); 
        Console.WriteLine($"Au prix de {price}");
    }
}