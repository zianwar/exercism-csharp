using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Linq;
using System;

public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();

        if (String.IsNullOrWhiteSpace(statement))
            return "Fine. Be that way!";

        var lettersCount = statement.Where(Char.IsLetter).Count();
        var lettersUpper = statement.Where(Char.IsLetter).All(Char.IsUpper);
        var question = statement.EndsWith("?");
        var shouting = lettersCount > 0 && lettersUpper;

        if (question && shouting)
            return "Calm down, I know what I'm doing!";

        if (question)
            return "Sure.";

        if (shouting)
            return "Whoa, chill out!";

        return "Whatever.";
    }

}