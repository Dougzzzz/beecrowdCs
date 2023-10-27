using System;
using System.Collections.Immutable;
using System.ComponentModel.Design;

string[] values = Console.ReadLine().Split();
double a = Convert.ToDouble(values[0]);
double b = Convert.ToDouble(values[1]);
double c = Convert.ToDouble(values[2]);

if ((a < b + c) && (b < a + c) && (c < a + b))
{
    Console.WriteLine($"Perimetro = {(a + b + c).ToString("F1")}");
}
else
{
    Console.WriteLine($"Area = {(((a + b) * c) / 2).ToString("F1")}");
}

Console.ReadLine();