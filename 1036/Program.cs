using System;

class URI
{

    static void Main(string[] args)
    {

        string[] values = Console.ReadLine().Split();
        double A = Convert.ToDouble(values[0]);
        double B = Convert.ToDouble(values[1]);
        double C = Convert.ToDouble(values[2]);
        double delta = (Math.Pow(B, 2)) - (4 * A * C);
        double r1;
        double r2;

        if (delta <= 0 || A == 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            r1 = (-B + Math.Sqrt(delta)) / (2 * A);
            r2 = (-B - Math.Sqrt(delta)) / (2 * A);
            Console.WriteLine($"R1 = {r1.ToString("F5")}");
            Console.WriteLine($"R2 = {r2.ToString("F5")}");
        }


    }

}