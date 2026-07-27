Product[] products = {new Product{
    ProductId = 1,
    ProductName = "Keyboard",
    Category = "Electronics"
},
new Product{
    ProductId = 2,
    ProductName = "Laptop",
    Category = "Electronics"
},
new Product{
    ProductId = 3,
    ProductName = "Mouse",
    Category = "Electronics"
}
};

Array.Sort(products, (a,b) => a.ProductId.CompareTo(b.ProductId));

Search s = new Search();
var p1 = s.LinearSearch(products, 3);
if(p1 != null)
{
    Console.WriteLine($"Linear Search:{p1.ProductName}");
}

var p2 = s.BinarySearch(products, 3);
if(p2 != null)
{
    Console.WriteLine($"Binary Search:{p2.ProductName}");
}