using System;
using System.Globalization;

Console.Write("Nhap ten: ");
string? name = Console.ReadLine();

if (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Ten bi loi!");
    return;
}

var words = name.Trim().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
for (int i = 0; i < words.Length; i++)
{
    var w = words[i];
    if (w.Length == 0) continue;
    words[i] = w.Length == 1
        ? ti.ToUpper(w)
        : ti.ToUpper(w.Substring(0, 1)) + ti.ToLower(w.Substring(1));
}

string normalized = string.Join(' ', words);
Console.WriteLine("Ten chuan: " + normalized);