﻿namespace ECommerce.WebApi.Models;

public class Product
{
    public Product()
    {
        Name = string.Empty;
        Category = new Category();
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}
