using System;
using System.Collections.Generic;

public class FindDuplicates
{
    public static void Main(string[] args)
    {
        int[] arr1 = { 1, 2, 3, 1, 2, 3 };
        int[] arr2 = { 16, 8, 31, 17, 15, 23, 17, 8 };
        int[] arr3 = { 5, 10, 16, 20, 10, 16 };

        List<int> result1 = FindDuplicates(arr1);
        List<int> result2 = FindDuplicates(arr2);
        List<int> result3 = FindDuplicates(arr3);

        Console.WriteLine("Duplicates in arr1: " + string.Join(", ", result1));
        Console.WriteLine("Duplicates in arr2: " + string.Join(", ", result2));
        Console.WriteLine("Duplicates in arr3: " + string.Join(", ", result3));
    }
    public static List<int> FindDuplicates(int[] arr)
    {
        List<int> duplicates = new List<int>();
        Dictionary<int, int> counts = new Dictionary<int, int>();

        foreach (int value in arr)
        {
            if (counts.ContainsKey(value))
            {
                counts[value]++;
            }
            else
            {
                counts[value] = 1;
            }
        }
        foreach (var kvp in counts)
        {
            if (kvp.Value > 1)
            {
                duplicates.Add(kvp.Key);
            }
        }
        return duplicates;
    }
}
