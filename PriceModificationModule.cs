
using System;
using System.Collections.Generic;

class PriceModificationModule{

    public static double reduction(List<Sell> panier, double price)
    {
        DateTime auj = DateTime.Now;
        auj = auj.AddMonths(-6);
        if(panier.FindAll(s => s.date >= auj).Count >= 3)
        {
            return price*0.9;
        }
        return price;
    }

    public static double augmentation(List<Sell> panier, double price, uint idProduct)
    {
        DateTime auj = DateTime.Now;
        auj = auj.AddYears(-1);
        if(panier.FindAll(s => s.idProduct == idProduct && s.date >= auj).Count > 5)
        {
            return price*1.05;
        }
        return price;
    }
}