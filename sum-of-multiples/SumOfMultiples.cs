using System.Linq;
using System.Collections.Generic;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
        => Enumerable.Range(0, max)
            .Where(i => multiples.Where(i => i != 0).Any(m => i % m == 0))
            .Sum();
}