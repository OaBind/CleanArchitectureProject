using System.Collections.Generic;

class PriceDB {
    public List<uint> products { get; set; }
    public List<double> prices { get; set; }

    public PriceDB() {
        products.Add(0);
        prices.Add(0);
    }
}