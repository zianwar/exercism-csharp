using System.Linq;
using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var nucleotides = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };

        if (!sequence.All((c) => nucleotides.Keys.Contains(c)))
        {
            throw new ArgumentException();
        }

        foreach (var c in sequence)
        {
            nucleotides[c]++;
        }

        return nucleotides;
    }
}