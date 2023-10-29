using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a List of integers
        List<int> numbers = new List<int>();

        // Add some elements to the List
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);
        numbers.Add(40);
        numbers.Add(50);

        // Access and display the elements in the List using a for loop
        int count = numbers.Count;

        Console.WriteLine("Accessing elements in the List using a for loop:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Element at index " + i + ": " + numbers[i]);
        }
    }
}
