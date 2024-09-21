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

            int year = Convert.ToInt32(input);

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
                Console.WriteLine($"{year} ist ein Schaltjahr.");
            }
            else
            {
                Console.WriteLine($"{year} ist kein Schaltjahr.");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Vielen Dank für die Verwendung des Schaltjahr-Prüfers!");
    }
}
