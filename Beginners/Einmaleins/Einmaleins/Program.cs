namespace Einmaleins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Das Einmaleins ===\n");

            // Schritt 1: Maximale Zahl erfragen
            Console.Write("Bis zu welcher Zahl soll das Einmaleins gehen? ");
            string eingabe = Console.ReadLine();
            int maxZahl = Convert.ToInt32(eingabe);

            Console.WriteLine(); // Leerzeile

            // Schritt 2: Einmaleins mit verschachtelten Schleifen ausgeben
            for (int zeile = 1; zeile <= maxZahl; zeile++)
            {
                for (int spalte = 1; spalte <= maxZahl; spalte++)
                {
                    int produkt = zeile * spalte;
                    Console.Write("{0,4}", produkt);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nDrücke eine Taste zum Beenden...");
            Console.ReadKey();
        }
    }
}
