
class ProductService: IProduct {
    public Product getProductById(uint id) {
        ProductDB productDB = new ProductDB();
        return productDB.getProductById(id);
    }
}