using System.Collections.Generic;

class PriceDB {
    public List<uint> products { get; set; }
    public List<double> prices { get; set; }

    public PriceDB() {
        products = new List<uint>();
        prices = new List<double>();
        products.Add(0);
        prices.Add(1000);
        products.Add(1);
        prices.Add(350);
        products.Add(2);
        prices.Add(600);
        products.Add(3);
        prices.Add(200);
    }

    public double getPriceByProductId(uint id){
        int idp = products.IndexOf(id);
        return prices[idp];
    }
}