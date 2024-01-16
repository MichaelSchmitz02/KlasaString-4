using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Unesite rečenicu: ");
        string unos = Console.ReadLine();


        string[] rijeci = unos.Split(' ');


    if (rijeci.Length > 0)
{
    Console.WriteLine("Prva riječ: " + rijeci[0]);
}
else
{
    Console.WriteLine("Rečenica je prazna.");
}
if (rijeci.Length > 0)
{
    Console.WriteLine("Zadnja riječ: " + rijeci[rijeci.Length - 1]);
}
else
{
    Console.WriteLine("Rečenica je prazna.");
}
    }
}


       
      


