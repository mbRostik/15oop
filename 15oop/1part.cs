using System;
using _15oop;
internal class Program
{
    static void Main()
    {
        Data n= new Data();
        
        lydi pup = new lydi(n.GetSQL());

        pup.GetAll();
        Console.WriteLine();

        pup.GetMin();
        Console.WriteLine();

        pup.GetMax();
        Console.WriteLine();

        pup.GetMinMatem();
        Console.WriteLine();

        pup.GetMaxMatem();
        Console.WriteLine();

        pup.GetGroups();
        Console.WriteLine();

        pup.GetMarks();
        Console.WriteLine("\n\n");

        pup.GetMinPredmet();
    }
}

