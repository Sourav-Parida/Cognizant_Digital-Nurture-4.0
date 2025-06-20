//using System;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }

    public Product(int productId, string productName, string category)
    {
        ProductId = productId;
        ProductName = productName;
        Category = category;
    }

    public void Display()
    {
        Console.WriteLine($"ID: {ProductId}, Name: {ProductName}, Category: {Category}");
    }
}

class Program
{
    // Linear Search
    static Product? LinearSearch(Product[] products, int targetId)
    {
        foreach (Product p in products)
        {
            if (p.ProductId == targetId)
                return p;
        }
        return null;
    }

    // Binary Search (array must be sorted by ProductId)
    static Product? BinarySearch(Product[] products, int targetId)
    {
        int low = 0, high = products.Length - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (products[mid].ProductId == targetId)
                return products[mid];
            else if (products[mid].ProductId < targetId)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return null;
    }

    static void Main(string[] args)
    {
        Product[] products = new Product[]
        {
            new Product(103, "Laptop", "Electronics"),
            new Product(101, "Shirt", "Clothing"),
            new Product(105, "Book", "Stationery"),
            new Product(102, "Headphones", "Electronics"),
            new Product(104, "Shoes", "Footwear")
        };

        Console.WriteLine("=== Linear Search ===");
        int searchId = 105;
        Product? result1 = LinearSearch(products, searchId);
        if (result1 != null)
        {
            Console.Write("Product Found: ");
            result1.Display();
        }
        else
        {
            Console.WriteLine("Product not found.");
        }

        Console.WriteLine("\n=== Binary Search (sorted by ID) ===");
        Array.Sort(products, (a, b) => a.ProductId.CompareTo(b.ProductId)); // sort for binary search
        Product? result2 = BinarySearch(products, searchId);
        if (result2 != null)
        {
            Console.Write("Product Found: ");
            result2.Display();
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }
}
