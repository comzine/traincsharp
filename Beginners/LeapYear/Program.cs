using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Willkommen zum Schaltjahr-Prüfer!");

        Console.Write("Bitte geben Sie ein Jahr ein: ");
        string input = Console.ReadLine();


        int jahr = Convert.ToInt32(input);

        bool istSchaltjahr;

        if (jahr % 400 == 0)
        {
            istSchaltjahr = true;
        }
        else if (jahr % 100 == 0)
        {
            istSchaltjahr = false;
        }
        else if (jahr % 4 == 0)
        {
            istSchaltjahr = true;
        }
        else
        {
            istSchaltjahr = false;
        }

        if (istSchaltjahr)
        {
            Console.WriteLine($"{jahr} ist ein Schaltjahr.");
        }
        else
        {
            Console.WriteLine($"{jahr} ist kein Schaltjahr.");
        }

        Console.WriteLine("Vielen Dank für die Verwendung des Schaltjahr-Prüfers!");
    }
}
