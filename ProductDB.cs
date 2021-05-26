using System.Collections.Generic;

class ProductDB {
    List<Product> products { get; set; }
    
    public ProductDB() {
        products.Add(new Product());
    }

}