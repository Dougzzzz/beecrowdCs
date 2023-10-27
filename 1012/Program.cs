using System;

class URI
{

    static void Main(string[] args)
    {
        string[] values = Console.ReadLine().Split();
        double A = double.Parse(values[0]);
        double B = double.Parse(values[1]);
        double C = double.Parse(values[2]);
        double pi = 3.14159;

        double triangle = (A * C) / 2.0;
        double circle = pi * (Math.Pow(C, 2));
        double trapeze = ((A + B) * C) / 2.0;
        double square = Math.Pow(B, 2);
        double retangle = A * B;

        Console.WriteLine($"TRIANGULO: {triangle.ToString("F3")}");
        Console.WriteLine($"CIRCULO: {circle.ToString("F3")}");
        Console.WriteLine($"TRAPEZIO: {trapeze.ToString("F3")}");
        Console.WriteLine($"QUADRADO: {square.ToString("F3")}");
        Console.WriteLine($"RETANGULO: {retangle.ToString("F3")}");
    }

}