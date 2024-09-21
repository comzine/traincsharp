using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Willkommen zum Schaltjahr-Prüfer!");

        while (true)
        {
            Console.Write("Bitte geben Sie ein Jahr ein (oder 'q' zum Beenden): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "q")
            {
                break;
            }

            if (int.TryParse(input, out int year))
            {
                bool istSchaltjahr = IstSchaltjahr(year);
                if (istSchaltjahr)
                {
                    Console.WriteLine($"{year} ist ein Schaltjahr.");
                }
                else
                {
                    Console.WriteLine($"{year} ist kein Schaltjahr.");
                }
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Jahreszahl ein.");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Vielen Dank für die Verwendung des Schaltjahr-Prüfers!");
    }

    static bool IstSchaltjahr(int jahr)
    {
        if (jahr % 4 == 0)
        {
            if (jahr % 100 == 0)
            {
                if (jahr % 400 == 0)
                {
                    return true;
                }
                return false;
            }
            return true;
        }
        return false;
    }
}
