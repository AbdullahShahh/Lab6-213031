using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a List of integers
        List<int> numbers = new List<int>();

        // Add some elements to the List
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);
        numbers.Add(4);
        numbers.Add(5);

        // Use the Count property to get the total number of elements in the List
        int count = numbers.Count;

        // Display the count
        Console.WriteLine("Total number of elements in the List: " + count);
    }
}
