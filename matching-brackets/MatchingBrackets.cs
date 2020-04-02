using System.Collections.Generic;

public static class MatchingBrackets
{
    public static bool IsPaired(string input)
    {
        if (string.IsNullOrEmpty(input))
            return true;

        var stack = new Stack<char>();
        foreach (char c in input)
        {
            if (!"{([])}".Contains(c))
                continue;

            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0)
                    return false;

                var x = stack.Pop();
                if (x == '(' && c != ')'
                    || x == '{' && c != '}'
                    || x == '[' && c != ']')
                    return false;
            }
        }
        return stack.Count == 0;
    }
}
