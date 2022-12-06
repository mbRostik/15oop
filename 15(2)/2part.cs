using System;
using _15_2_;
internal class Program
{
    static void Main()
    {
        tovaru shtoto=new tovaru();
        shtoto.GetAll();

        Console.WriteLine();
        shtoto.GetTypes();
        Console.WriteLine();

        Console.WriteLine();
        shtoto.GetManagers();
        Console.WriteLine();

        Console.WriteLine();
        shtoto.GetMaxKol();
        Console.WriteLine();

        Console.WriteLine();
        shtoto.GetMinKol();
        Console.WriteLine();

        Console.WriteLine();
        shtoto.GetMaxPrice();
        Console.WriteLine();

        Console.WriteLine();
        shtoto.GetMinPrice();
        Console.WriteLine();
    }
}

