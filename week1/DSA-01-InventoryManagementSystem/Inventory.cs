public class Inventory
{
    private Dictionary<int, Product> products = new Dictionary<int, Product>();
    public void AddProduct(Product P)
    {
        products[P.ProductId] = P;
        Console.WriteLine("Added");
    }

    public void UpdatedQuantity(int id, int qty)
    {
        if (products.ContainsKey(id))
        {
            products[id].Quantity = qty;
            Console.WriteLine("Updated");
        }
    }

    public void DeleteProduct(int id)
    {
        products.Remove(id);
        Console.WriteLine("Deleted");
    }

    public void Display()
    {
        foreach(var p in products.Values){
            Console.WriteLine($"{p.ProductId} {p.ProductName} {p.Quantity} {p.Price}");
        }
    }
}