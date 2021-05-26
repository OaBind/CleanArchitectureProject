using System.Collections.Generic;

class PriceDB {
    public List<uint> products { get; set; }
    public List<double> prices { get; set; }

    public PriceDB() {
        products.Add(0);
        prices.Add(0);
    }

    public double getPriceByProductId(uint id){
        int idp = products.IndexOf(id);
        return prices[idp];
    }
}