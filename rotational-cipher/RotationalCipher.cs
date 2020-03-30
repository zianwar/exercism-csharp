using System.Linq;
using System;

public static class RotationalCipher
{
    private static char Rotate(char c, int key)
    {
        if (Char.IsLetter(c))
        {
            int k = Char.IsUpper(c) ? 'A' : 'a';
            return (char)((c - k + key) % 26 + k);
        }
        return c;
    }

    public static string Rotate(string text, int shiftKey)
        => new string(text.Select((c) => Rotate(c, shiftKey)).ToArray());
}