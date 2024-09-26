using Microsoft.EntityFrameworkCore;

namespace Shop;

[PrimaryKey(nameof(ProductId), nameof(CategoryId))]
public class ProductCategory
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public Product Product { get; set; }
    public Category Category { get; set; }
}
