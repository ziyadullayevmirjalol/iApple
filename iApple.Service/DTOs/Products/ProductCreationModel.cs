﻿namespace iApple.Service.DTOs.Products;

public class ProductCreationModel
{
    public string Name { get; set; }
    public string Color { get; set; }
    public decimal Price { get; set; }
    public long Quantity {  get; set; }
    public string Storage { get; set; }
    public string Description { get; set; }
    public string CategoryName { get; set; }
}