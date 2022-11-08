using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
        return data.Select(i => i[0] > 54 && i[1] > 7 ? "Senior" : "Open");
    }
}