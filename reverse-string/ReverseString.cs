﻿using System.Linq;
using System;

public static class ReverseString
{
    public static string Reverse(string input)
        => new string(input.Reverse().ToArray());
}