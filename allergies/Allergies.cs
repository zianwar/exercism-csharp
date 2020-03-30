using System.Linq;
using System;

public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private Allergen mask;

    public Allergies(int mask)
        => this.mask = (Allergen)mask;

    public bool IsAllergicTo(Allergen allergen)
        => mask.HasFlag(allergen);

    public Allergen[] List()
        => Enum.GetValues(typeof(Allergen))
            .Cast<Allergen>()
            .Where(IsAllergicTo)
            .ToArray();
}