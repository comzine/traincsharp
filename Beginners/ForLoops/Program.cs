namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Übung: For-Schleifen ===\n");

            // Aufgabe 1: Zahlen von 1 bis 10
            Console.WriteLine("Aufgabe 1: Zahlen von 1 bis 10");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(); // Leerzeile

            // Aufgabe 2: Countdown
            Console.WriteLine("Aufgabe 2: Countdown");
            Console.Write("Gib eine Startzahl ein: ");
            string input = Console.ReadLine();
            int startZahl = Convert.ToInt32(input);

            for (int i = startZahl; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Start!");

            Console.WriteLine(); // Leerzeile

            // Aufgabe 3: Summe berechnen
            Console.WriteLine("Aufgabe 3: Summe berechnen");
            Console.Write("Gib eine positive Zahl ein: ");
            string input2 = Console.ReadLine();
            int zahl = Convert.ToInt32(input2);

            int summe = 0;
            for (int i = 1; i <= zahl; i++)
            {
                summe = summe + i;
            }
            Console.WriteLine("Die Summe aller Zahlen von 1 bis " + zahl + " ist: " + summe);

            Console.WriteLine(); // Leerzeile

            // Aufgabe 4: Multiplikationstabelle
            Console.WriteLine("Aufgabe 4: Multiplikationstabelle");
            Console.Write("Gib eine Zahl zwischen 1 und 10 ein: ");
            string input3 = Console.ReadLine();
            int multiplikator = Convert.ToInt32(input3);

            for (int i = 1; i <= 10; i++)
            {
                int ergebnis = multiplikator * i;
                Console.WriteLine(multiplikator + " x " + i + " = " + ergebnis);
            }
        }
    }
}
