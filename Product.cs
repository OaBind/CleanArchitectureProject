public class Product {
    public uint id {get; set;}
    public string name { get; set; }
    public string description { get; set; }
    public string category { get; set; }
    public string details { get; set; }

    public Product(uint id, string name, string description, string category, string details) {
        this.id = id;
        this.name = name;
        this.description = description;
        this.category = category;
        this.details = details;
    }
}