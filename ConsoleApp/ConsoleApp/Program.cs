using StringExtensions;

string[] tests = { "Hello", "world", "Azure", "devOps" };
foreach (var s in tests)
    Console.WriteLine($"{s} -> {s.StartsWithUpperCase()}");

