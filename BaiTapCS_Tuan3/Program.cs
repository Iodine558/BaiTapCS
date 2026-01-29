using System;
using System.Diagnostics.Metrics;

// Bai 4: Tinh tong mang so nguyen
//Ten: Pham Nguyen Minh Hai
//MSSV: 2415053122211
Console.WriteLine("Bai 4: Tinh tong mang so nguyen");
Console.Write("Nhap so phan tu n: ");
string? input = Console.ReadLine();
int n;
if (!int.TryParse(input, out n) || n < 0)
{
    Console.WriteLine("Nhap n khong hop le");
}
else
{
    int[]? arr4 = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Nhap phan tu thu {i + 1}: ");
        input = Console.ReadLine();
        int.TryParse(input, out arr4[i]);
    }

    if (arr4 == null)
    {
        Console.WriteLine("Mang chua duoc khoi tao");
    }
    else
    {
        int sum = 0;
        for (int i = 0; i < arr4.Length; i++)
            sum += arr4[i];
        Console.WriteLine($"Tong = {sum}");
    }
}

// Bai 5: Tim gia tri lon nhat trong mang
//Ten: Pham Nguyen Minh Hai
//MSSV: 2415053122211
Console.WriteLine("Bai 5: Tim gia tri lon nhat trong mang");
Console.Write("Nhap so phan tu n: ");
input = Console.ReadLine();
if (!int.TryParse(input, out n) || n < 0)
{
    Console.WriteLine("Nhap n khong hop le");
}
else
{
    int[]? arr5 = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Nhap phan tu thu {i + 1}: ");
        input = Console.ReadLine();
        int.TryParse(input, out arr5[i]);
    }

    if (arr5 == null || arr5.Length == 0)
    {
        Console.WriteLine("Mang rong hoac null");
    }
    else
    {
        int max = arr5[0];
        for (int i = 1; i < arr5.Length; i++)
        {
            if (arr5[i] > max)
                max = arr5[i];
        }
        Console.WriteLine($"Gia tri lon nhat = {max}");
    }
}

// Bai 6: Dem so phan tu chan
//Ten: Pham Nguyen Minh Hai
//MSSV: 2415053122211
Console.WriteLine("Bai 6: Dem so phan tu chan");
Console.Write("Nhap so phan tu n: ");
input = Console.ReadLine();
if (!int.TryParse(input, out n) || n < 0)
{
    Console.WriteLine("Nhap n khong hop le");
}
else
{
    int[]? arr6 = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Nhap phan tu thu {i + 1}: ");
        input = Console.ReadLine();
        int.TryParse(input, out arr6[i]);
    }

    if (arr6 == null )
    {
        Console.WriteLine($"So phan tu chan = 0");
    }
    else
    {
        int counter = 0;
        for (int i = 0; i < arr6.Length; i++)
        {
            if (arr6[i] % 2 == 0) counter++;
        }
        Console.WriteLine($"So phan tu chan = {counter}");
    }
}

// Bai 7: Tach ho ten thanh mang
//Ten: Pham Nguyen Minh Hai
//MSSV: 2415053122211
Console.WriteLine("Bai 7: Tach ho ten thanh mang");
Console.Write("Nhap ho ten: ");
string? fullname = Console.ReadLine();
if (fullname == null)
{
    Console.WriteLine("Khong tach duoc");
}
else
{
    string[] words = fullname.Trim().Split(' ');
    if (words != null)
    {
        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine(words[i]);
        }
    }
}

// Bai 8: Tim tu dai nhat trong chuoi
//Ten: Pham Nguyen Minh Hai
//MSSV: 2415053122211
Console.WriteLine("Bai 8: Tim tu dai nhat trong chuoi");
Console.Write("Nhap mot cau: ");
string? sentence = Console.ReadLine();
if (sentence == null)
{
    Console.WriteLine("Chuoi null");
}
else
{
    string[] words = sentence.Trim().Split(' ');
    string longest = words[0];
    for (int i = 1; i < words.Length; i++)
    {
        if (words[i].Length > longest.Length)
            longest = words[i];
    }
    Console.WriteLine($"Tu dai nhat: {longest}");
}

// Bai 9: Dem so chuoi khac null va khac rong trong mang
//Ten: Pham Nguyen Minh Hai
//MSSV: 2415053122211
Console.WriteLine("Bai 9: Dem so chuoi khac null va khac rong trong mang");
string[] arr9 = new string[] { "Hello", null, "", "World", " " };
//Co 3 chuoi khac null va rong
int countNullorRong = 0;
for (int i = 0; i < arr9.Length; i++)
{
    if (arr9[i] != null && arr9[i] != "")
        countNullorRong++;
}
Console.WriteLine($"So chuoi khac null va rong la: {countNullorRong}");
