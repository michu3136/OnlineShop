﻿namespace Domain.Entities
{
  public class Product
  {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ProductDetail ProductDetail { get; set; }
    public Category Category { get; set; }
    protected Product()
    {

    }

    public Product(string name)
    {
      Name = name;
      Id= Guid.NewGuid();
    }

  }
}
