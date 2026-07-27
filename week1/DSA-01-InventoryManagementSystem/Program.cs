Inventory inventory = new Inventory();
inventory.AddProduct(new Product{
    ProductId = 1, 
    ProductName = "Laptop",
    Quantity = 10,
    Price = 50000
});

inventory.AddProduct(new Product{
    ProductId = 2, 
    ProductName = "Monitor",
    Quantity = 30,
    Price = 6000
});

inventory.UpdatedQuantity(1, 20);

inventory.DeleteProduct(2);

inventory.Display();