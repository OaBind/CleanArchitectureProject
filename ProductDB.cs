using System.Collections.Generic;

class ProductDB {
    List<Product> products { get; set; }
    
    public ProductDB() {
        products = new List<Product>();
        products.Add(new Product(0, "ordinateur", "super ordinateur tkt", "Multimédia", "some details"));
        products.Add(new Product(1, "aspirateur", "Fais un effort passe un coup", "Electromenager", "some details"));
        products.Add(new Product(2, "telephone", "nokia 3310 on est la", "Multimédia", "some details"));
        products.Add(new Product(3, "cafetiere", "tu auras besoin de moi", "Electromenager", "some details"));
    }

    public Product getProductById(uint id){
        return products.Find(p => p.id == id);
    }

}