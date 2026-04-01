using System;
using System.Linq;
using System.Collections.Generic;

var rng = new Random();

Console.In
    .ReadLines()
    .Select(l => l.ScrambleLine(rng))
    .ForEach(Console.WriteLine);     

static class TextReaderExtensions
{
    public static IEnumerable<string> ReadLines(this System.IO.TextReader reader)
    {
        string? line;
        while ((line = reader.ReadLine()) != null)
            yield return line;
    }
}

static class StringExtensions
{
    public static string ScrambleLine(this string line, Random rng)
        => line
            .Split(' ')
            .Select(x => x.ScrambleWord(rng))
            .JoinToString();
    
    public static string ScrambleWord(this string s, Random rng)
        => s.Length > 3
            ? $"{s[0]}{string.Concat(s[1..^1].OrderBy(_ => rng.Next()))}{s[^1]}"
            : s;

    public static string JoinToString(this IEnumerable<string> source, string separator = " ")
        => string.Join(separator, source);
}

static class EnumerableExtensions
{
    public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
    {
        foreach (var item in source)
            action(item);
    }
}
