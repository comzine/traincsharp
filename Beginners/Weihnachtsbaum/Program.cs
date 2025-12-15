namespace Weihnachtsbaum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ASCII-Weihnachtsbaum ===\n");

            // Schritt 1: Höhe der Baumkrone erfragen
            Console.Write("Gib die Höhe der Baumkrone ein: ");
            string eingabe = Console.ReadLine();
            int hoehe = Convert.ToInt32(eingabe);

            Console.WriteLine(); // Leerzeile

            // Schritt 2: Baumkrone zeichnen
            for (int i = 0; i < hoehe; i++)
            {
                // Leerzeichen für Zentrierung ausgeben
                int anzahlLeerzeichen = hoehe - i - 1;
                for (int j = 0; j < anzahlLeerzeichen; j++)
                {
                    Console.Write(" ");
                }

                // Sterne ausgeben
                int anzahlSterne = 2 * i + 1;
                for (int j = 0; j < anzahlSterne; j++)
                {
                    Console.Write("*");
                }

                // Zeilenumbruch
                Console.WriteLine();
            }

            // Schritt 3: Baumstamm zeichnen (immer 2 Zeilen hoch, 3 Zeichen breit)
            for (int i = 0; i < 2; i++)
            {
                // Leerzeichen für Zentrierung des Stamms
                int anzahlLeerzeichen = hoehe - 2;
                for (int j = 0; j < anzahlLeerzeichen; j++)
                {
                    Console.Write(" ");
                }

                // Stamm (3 Rauten)
                Console.Write("###");

                // Zeilenumbruch
                Console.WriteLine();
            }

            Console.WriteLine("\nFrohe Weihnachten!");
            Console.WriteLine("Drücke eine Taste zum Beenden...");
            Console.ReadKey();
        }
    }
}
