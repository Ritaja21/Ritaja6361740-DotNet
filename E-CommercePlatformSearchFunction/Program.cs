using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Sample product list
        Product[] products = new Product[]
        {
            new Product(1, "Laptop", "Electronics"),
            new Product(2, "Shoes", "Fashion"),
            new Product(3, "Keyboard", "Electronics"),
            new Product(4, "Book", "Education"),
            new Product(5, "Phone", "Electronics")
        };

        // Unsorted list for linear search
        Console.WriteLine(" Linear Search: Searching for 'Phone'");
        var linearResult = Search.LinearSearch(products, "Phone");
        Console.WriteLine(linearResult != null ? linearResult.ToString() : "Not Found");

        // Sort list for binary search
        var sortedProducts = products.OrderBy(p => p.ProductName).ToArray();

        Console.WriteLine("\n Binary Search: Searching for 'Phone'");
        var binaryResult = Search.BinarySearch(sortedProducts, "Phone");
        Console.WriteLine(binaryResult != null ? binaryResult.ToString() : "Not Found");

        // Time complexity discussion
        Console.WriteLine("\n Time Complexity:");
        Console.WriteLine("Linear Search - O(n): Scans each element.");
        Console.WriteLine("Binary Search - O(log n): Efficient for sorted data.");
    }
}
