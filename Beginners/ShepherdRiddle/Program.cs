// Wir starten bei 1, da 0 Schafe nicht sinnvoll wären, und suchen bis unter 400 Schafe
for (int i = 1; i < 400; i++)
{
    // Überprüfen, ob die Zahl i ein Rest von 1 hat, wenn durch 2 bis 6 dividiert wird
    // und gleichzeitig durch 7 ohne Rest teilbar ist
    if ((i % 2 == 1) && (i % 3 == 1) && (i % 4 == 1) && (i % 5 == 1) && (i % 6 == 1) && (i % 7 == 0))
    {
        Console.WriteLine("Der Schäfer hat {0} Schafe.", i);
        break; // Schleife beenden, wenn die Bedingung erfüllt ist
    }
}

Console.ReadKey();