using System;
using _15oop;
internal class Program
{
    static void Main()
    {
        Data n= new Data();
        
        debilu pup = new debilu(n.GetSQL());

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

