using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions;

public static class StringHelper
{
    public static bool StartsWithUpperCase(this string value)
    {
        if (string.IsNullOrEmpty(value)) return false;
        return char.IsUpper(value[0]);
    }
}

