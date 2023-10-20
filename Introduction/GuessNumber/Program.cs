using System;

class Program
{
    static void Main()
    {
        int geheimeZahl = 17;
        int gerateneZahl = 0;
        string eingabe;
        int spielmodus = 0;

        Console.WriteLine("Willkommen zum Zahlenraten-Spiel!");

        do
        {
            Console.WriteLine("Bitte wählen Sie einen Spielmodus:");
            Console.WriteLine("1 - Einzelspieler");
            Console.WriteLine("2 - Zweispieler");
            eingabe = Console.ReadLine();
            spielmodus = Convert.ToInt32(eingabe);
        } while (spielmodus != 1 && spielmodus != 2);

        if (spielmodus == 1)
        {
            // Einzelspielermodus
            Random rand = new Random();
            geheimeZahl = rand.Next(1, 21);
        }
        else
        {
            // Zweispielermodus

            do
            {
                System.Console.Write("Bitte geben Sie die geheime Zahl zwischen 1 und 20 ein: ");
                eingabe = Console.ReadLine();
                geheimeZahl = Convert.ToInt32(eingabe);
            } while (geheimeZahl < 1 || geheimeZahl > 20);
        }

        Console.Clear();
        System.Console.WriteLine("Die geheime Zahl wurde gespeichert - viel Spaß beim Raten!");

        while (geheimeZahl != gerateneZahl)
        {
            Console.Write("Bitte geben Sie eine Zahl zwischen 1 und 20 ein: ");
            eingabe = Console.ReadLine();
            gerateneZahl = Convert.ToInt32(eingabe);

            if (gerateneZahl < 1 || gerateneZahl > 20)
            {
                Console.WriteLine("Die eingegebene Zahl muss zwischen 1 und 20 liegen.");
            }
            else if (gerateneZahl < geheimeZahl)
            {
                Console.WriteLine("Die geratene Zahl ist zu niedrig. Versuchen Sie es erneut.");
            }
            else if (gerateneZahl > geheimeZahl)
            {
                Console.WriteLine("Die geratene Zahl ist zu hoch. Versuchen Sie es erneut.");
            }
            else
            {
                Console.WriteLine("Herzlichen Glückwunsch! Sie haben die Zahl richtig geraten.");
            }
        }

        Console.WriteLine("Vielen Dank fürs Spielen. Das Spiel ist beendet.");
        Console.ReadKey();
    }
}
