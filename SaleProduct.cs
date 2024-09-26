using Microsoft.EntityFrameworkCore;

namespace Shop;

[PrimaryKey(nameof(SaleId), nameof(ProductId))]
public class SaleProduct
{
    public int SaleId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }
    public Sale Sale { get; set; }
    public Product Product { get; set; }
}
