using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Willkommen zum Fibonacci-Sequenz Generator!");

        do
        {
            Console.Write("Bitte geben Sie das Limit für die Fibonacci-Sequenz ein: ");
            if (int.TryParse(Console.ReadLine(), out int limit) && limit > 0)
            {
                GenerateFibonacciSequence(limit);
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine positive ganze Zahl ein.");
                continue;
            }

            Console.Write("Möchten Sie eine weitere Sequenz generieren? (j/n): ");
        } while (Console.ReadLine().ToLower() == "j");

        Console.WriteLine("Vielen Dank für die Verwendung des Fibonacci-Sequenz Generators!");
    }

    static void GenerateFibonacciSequence(int limit)
    {
        int a = 0, b = 1;
        Console.WriteLine($"Fibonacci-Sequenz bis {limit}:");
        
        for (int i = 0; a <= limit; i++)
        {
            Console.Write($"{a} ");
            int temp = a;
            a = b;
            b = temp + b;

            if (i % 10 == 9)  // Neue Zeile nach jeweils 10 Zahlen
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine();

        // Zusätzliche Herausforderung: Berechnung der Goldenen Ratio
        if (a > 0)
        {
            double goldenRatio = (double)b / a;
            Console.WriteLine($"Annäherung an die Goldene Ratio: {goldenRatio:F6}");
        }
    }
}
