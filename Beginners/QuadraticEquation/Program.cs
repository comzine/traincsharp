using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Quadratische Gleichung lösen: ax² + bx + c = 0 ===\n");

        // Eingabe der Koeffizienten
        Console.Write("Gib den Wert für a ein: ");
        string inputA = Console.ReadLine();
        double a = Convert.ToDouble(inputA);

        Console.Write("Gib den Wert für b ein: ");
        string inputB = Console.ReadLine();
        double b = Convert.ToDouble(inputB);

        Console.Write("Gib den Wert für c ein: ");
        string inputC = Console.ReadLine();
        double c = Convert.ToDouble(inputC);

        Console.WriteLine();

        // Validierung: a darf nicht 0 sein
        if (a == 0)
        {
            Console.WriteLine("Fehler: a darf nicht 0 sein! Dies ist keine quadratische Gleichung.");
            return;
        }

        // Gleichung ausgeben
        Console.WriteLine($"Gleichung: {a}x² + {b}x + {c} = 0");
        Console.WriteLine();

        // Diskriminante berechnen: D = b² - 4ac
        double discriminant = b * b - 4 * a * c;

        Console.WriteLine($"Diskriminante: {discriminant}");

        // Fallunterscheidung basierend auf der Diskriminante
        if (discriminant < 0)
        {
            // Keine reellen Lösungen
            Console.WriteLine("Die Gleichung hat keine reellen Lösungen.");
        }
        else if (discriminant == 0)
        {
            // Eine Lösung (Doppellösung)
            double x = -b / (2 * a);
            Console.WriteLine("Die Gleichung hat eine Lösung:");
            Console.WriteLine($"x = {x}");
        }
        else
        {
            // Zwei verschiedene Lösungen
            // x₁ = (-b + √D) / (2a)
            // x₂ = (-b - √D) / (2a)

            double sqrtDiscriminant = Math.Sqrt(discriminant);
            double x1 = (-b + sqrtDiscriminant) / (2 * a);
            double x2 = (-b - sqrtDiscriminant) / (2 * a);

            Console.WriteLine("Die Gleichung hat zwei Lösungen:");
            Console.WriteLine($"x₁ = {x1}");
            Console.WriteLine($"x₂ = {x2}");
        }
    }
}
