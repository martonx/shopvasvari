﻿namespace Shop;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<ProductCategory> Products { get; set; } = [];
}
