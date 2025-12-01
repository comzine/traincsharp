namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Würfel-Simulator ===\n");

            // Random-Objekt erstellen (nur einmal am Anfang!)
            Random zufall = new Random();

            // Aufgabe 1: Einzelner Würfelwurf
            Console.WriteLine("Aufgabe 1: Einzelner Würfelwurf");
            int wurf = zufall.Next(1, 7);
            Console.WriteLine("Du hast eine " + wurf + " gewürfelt!");

            Console.WriteLine(); // Leerzeile

            // Aufgabe 2: Mehrere Würfelwürfe
            Console.WriteLine("Aufgabe 2: Mehrere Würfelwürfe");
            Console.Write("Wie oft möchtest du würfeln? ");
            string input = Console.ReadLine();
            int anzahl = Convert.ToInt32(input);

            for (int i = 1; i <= anzahl; i++)
            {
                int aktuellerwurf = zufall.Next(1, 7);
                Console.WriteLine("Wurf " + i + ": " + aktuellerwurf);
            }

            Console.WriteLine(); // Leerzeile

            // Aufgabe 3: Würfelsumme berechnen
            Console.WriteLine("Aufgabe 3: Würfelsumme berechnen");
            Console.Write("Wie viele Würfel möchtest du werfen? ");
            string input2 = Console.ReadLine();
            int wuerfelAnzahl = Convert.ToInt32(input2);

            int summe = 0;
            for (int i = 1; i <= wuerfelAnzahl; i++)
            {
                int wuerfelwurf = zufall.Next(1, 7);
                Console.WriteLine("Würfel " + i + ": " + wuerfelwurf);
                summe = summe + wuerfelwurf;
            }
            Console.WriteLine("Gesamtsumme: " + summe);

            Console.WriteLine(); // Leerzeile

            // Aufgabe 4: Gerade oder ungerade Würfe zählen
            Console.WriteLine("Aufgabe 4: Gerade oder ungerade Würfe zählen");
            Console.Write("Wie oft soll gewürfelt werden? ");
            string input3 = Console.ReadLine();
            int wurfAnzahl = Convert.ToInt32(input3);

            int geradeAnzahl = 0;
            int ungeradeAnzahl = 0;

            for (int i = 1; i <= wurfAnzahl; i++)
            {
                int ergebnis = zufall.Next(1, 7);
                Console.WriteLine("Wurf " + i + ": " + ergebnis);

                if (ergebnis % 2 == 0)
                {
                    geradeAnzahl = geradeAnzahl + 1;
                }
                else
                {
                    ungeradeAnzahl = ungeradeAnzahl + 1;
                }
            }

            Console.WriteLine("\nGerade Würfe: " + geradeAnzahl);
            Console.WriteLine("Ungerade Würfe: " + ungeradeAnzahl);
        }
    }
}
