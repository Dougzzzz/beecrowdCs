using System;

class URI
{

    static void Main(string[] args)
    {

        string name = Console.ReadLine();
        double salary = Convert.ToDouble(Console.ReadLine());
        double sales = Convert.ToDouble(Console.ReadLine());
        double salesCommission = 0.15;

        double totalSalary = salary + (sales * 0.15);
        Console.WriteLine($"TOTAL = R$ {totalSalary.ToString("F2")}");
    }

}