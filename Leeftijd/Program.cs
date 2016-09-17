using System;

class Hallo2
{
    static void Main()
    {
        
        string naam;
        Console.WriteLine("Wat is je naam?");
        naam = Console.ReadLine();
        Console.WriteLine("Hallo, " + naam + "!");
        Console.WriteLine("Je naam heeft " + naam.Length + " letters.");
        //Console.ReadLine();
        Console.WriteLine("In welk jaar ben je geboren?");
        string leeftijdtext = Console.ReadLine();
        int leeftijdint = Int32.Parse(leeftijdtext);
        DateTime date; // = new DateTime();
        date = DateTime.Now;
        int jaar = date.Year;
        Console.WriteLine("Je bent " + (jaar - leeftijdint) + " jaar oud.");
        Console.WriteLine(DateTime.Now);
        Console.ReadKey();
    }
}