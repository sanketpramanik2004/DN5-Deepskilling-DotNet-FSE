public class Search
{
    public Product LinearSearch(Product[] products, int target)
    {
        foreach(var p in products)
        {
            if(p.ProductId == target)
            {
                return p;
            }
        }
                return null;
    }

    public Product BinarySearch(Product[] products, int target)
    {
        int left = 0; 
        int right = products.Length -1;

        while (left <= right)
        {
            int mid = (left + right)/2;
            if(products[mid].ProductId == target)
            {
                return products[mid];
            }
            else if(products[mid].ProductId < target)
            {
                left = mid+1;
            }
            else
            {
                right = mid-1;
            }
        }
        return null;
    }
}