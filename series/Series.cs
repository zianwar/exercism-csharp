using System.Collections.Generic;
using System;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        if (sliceLength <= 0 || sliceLength > numbers.Length)
            throw new ArgumentException();

        var substrings = new List<string>();
        for (int i = 0; i <= numbers.Length - sliceLength; i++)
        {
            substrings.Add(numbers.Substring(i, sliceLength));
        }

        return substrings.ToArray();
    }
}