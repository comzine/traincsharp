try
{
    Console.Write("Bitte geben Sie ein Jahr ein: ");
    int year = Convert.ToInt32(Console.ReadLine());

    // Berechnung des Wochentags des 1. November
    int q = 1; // Tag des Monats
    int m = 11; // Monat November
    int J = year / 100; // Jahrhundert
    int K = year % 100; // Jahr des Jahrhunderts
    int h = (q + 13 * (m + 1) / 5 + K + K / 4 + J / 4 - 2 * J) % 7;
    int dayOfWeek = ((h + 5) % 7) + 1; // Umwandlung in gängiges Format (1 = Sonntag, 2 = Montag, ...)

    // Berechnung des Datums des vierten Donnerstags im November
    int offset = 4 - dayOfWeek; // Tage bis zum ersten Donnerstag
    if (offset < 0) offset += 7;
    int fourthThursday = 1 + offset + 3 * 7; // Erster Donnerstag + 3 Wochen

    // Black Friday ist der Tag nach dem vierten Donnerstag
    int blackFridayDate = fourthThursday + 1;

    Console.WriteLine($"Black Friday im Jahr {year} ist am: {blackFridayDate}. November");
}
catch (Exception ex)
{
    Console.WriteLine($"Ein Fehler ist aufgetreten: {ex.Message}");
}

Console.ReadKey();
