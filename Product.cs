namespace Shop;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public List<ProductCategory> Categories { get; set; } = [];
}
