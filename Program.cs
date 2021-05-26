using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            uint idProduct = uint.Parse(args[0]);
            uint idUser;
            ProductService productService = new ProductService();
            PriceService priceService = new PriceService();
            Product product;
            double price;
            
            if (args.Length > 1) {
                idUser = uint.Parse(args[1]);
            } else {
                product = productService.getProductById(idProduct);
                price = priceService.getProductPriceById(idProduct);
            }
        }
    }
}
