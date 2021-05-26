using System.Collections.Generic;

class ProductDB {
    List<Product> products { get; set; }
    
    public ProductDB() {
        products.Add(new Product());
    }

    public Product getProductById(uint id){
        return products.Find(p => p.id == id);
    }

}