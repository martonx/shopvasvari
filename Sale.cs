namespace Shop;

public class Sale
{
    public int Id { get; set; }
    public DateTime CurrentDate { get; set; } = DateTime.Now;
    public List<SaleProduct> Products { get; set; } = [];
}
