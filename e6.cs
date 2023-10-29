using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a List of strings
        List<string> fruits = new List<string>();

        // Add some elements to the List
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Orange");
        fruits.Add("Mango");

        // Use the Count property to get the total number of elements in the List
        int count = fruits.Count;

        Console.WriteLine("Total number of elements in the List: " + count);

        // Access and display the elements in the List
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Element at index " + i + ": " + fruits[i]);
        }
    }
}
