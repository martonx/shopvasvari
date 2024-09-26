// See https://aka.ms/new-console-template for more information
using Shop;

Console.WriteLine("Hello, World!");

var db = new ShopContext();

if (!db.Products.Any())
{
    var milk = new Product { Name = "Tej" };
    db.Products.Add(milk);
    var bread = new Product { Name = "Kenyér" };
    db.Products.Add(bread);
    var ball = new Product { Name = "Labda" };
    db.Products.Add(ball);
    var nerfGun = new Product { Name = "Nerf gun" };
    db.Products.Add(nerfGun);

    var foodCategory = new Category { Name = "Élelmiszer" };
    foodCategory.Products.Add(new ProductCategory { Category = foodCategory, Product = milk });
    foodCategory.Products.Add(new ProductCategory { Category = foodCategory, Product = bread });
    var toyCategory = new Category { Name = "Játék" };
    foodCategory.Products.Add(new ProductCategory { Category = toyCategory, Product = ball });
    foodCategory.Products.Add(new ProductCategory { Category = toyCategory, Product = nerfGun });

    db.SaveChanges();
}
