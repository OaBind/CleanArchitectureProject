using System;
using System.Collections.Generic;

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
            HistoricService historicService = new HistoricService();
            Product product;
            double price;
            
            if (args.Length > 1) {
                // Use case 2
                idUser = uint.Parse(args[1]);
                product = productService.getProductById(idProduct);
                price = priceService.getProductPriceById(idProduct);
                List<Sell> sells = historicService.getUserHistoric(idUser);
                double reducedPrice = PriceModificationModule.reduction(sells, price);
                double increasedPrice = PriceModificationModule.augmentation(sells, price, idProduct);
                if(increasedPrice != price) {
                    price = increasedPrice;
                } else if(reducedPrice != price) {
                    price = reducedPrice;
                }
            } else {
                // Use case 1
                product = productService.getProductById(idProduct);
                price = priceService.getProductPriceById(idProduct);
            }
            DisplayModule.displayProduct(product,price);
        }
    }
}
