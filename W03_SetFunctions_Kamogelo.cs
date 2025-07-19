using System;
using System.Collections.Generic;

class Program
{
    // Custom Intersection Function
    static HashSet<int> CustomIntersection(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> result = new HashSet<int>();
        foreach (int item in set1)
        {
            if (set2.Contains(item))
            {
                result.Add(item);
            }
        }
        return result;
    }

    // Custom Union Function
    static HashSet<int> CustomUnion(HashSet<int> set1, HashSet<int> set2)
    {
        HashSet<int> result = new HashSet<int>();
        foreach (int item in set1)
        {
            result.Add(item);
        }
        foreach (int item in set2)
        {
            result.Add(item);
        }
        return result;
    }

    static void Main()
    {
        var setA = new HashSet<int> { 1, 2, 3 };
        var setB = new HashSet<int> { 2, 3, 4 };

        var intersection = CustomIntersection(setA, setB);
        var union = CustomUnion(setA, setB);

        Console.WriteLine("Intersection: " + string.Join(", ", intersection)); // Output: 2, 3
        Console.WriteLine("Union: " + string.Join(", ", union));               // Output: 1, 2, 3, 4
    }
}
