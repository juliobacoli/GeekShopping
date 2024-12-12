﻿namespace GeekShopping.ProductsAPI.Data.ValueObjects;

public class ProductVO
{
    public long Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public string CatergoryName { get; set; }
    public string ImageUrl { get; set; }
}
