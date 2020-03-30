using System;

public static class ResistorColor
{
    private static string[] colorsMap =
     {
        "black", "brown", "red",
        "orange", "yellow", "green",
        "blue", "violet", "grey", "white"
    };

    public static int ColorCode(string color)
    {
        return Array.IndexOf(colorsMap, color);
    }

    public static string[] Colors()
    {
        return colorsMap;
    }
}