Console.Write("Bitte geben Sie ein Jahr ein: ");
int jahr = Convert.ToInt32(Console.ReadLine());

if (jahr < 1583)
{
    Console.WriteLine("Die Gaußsche Osterformel gilt erst ab dem Jahr 1583.");
    return;
}

int G = jahr % 19;
int C = jahr / 100;
int H = (C - C / 4 - (8 * C + 13) / 25 + 19 * G + 15) % 30;
int I = H - H / 28 * (1 - 29 / (H + 1) * (21 - G) / 11);
int J = (jahr + jahr / 4 + I + 2 - C + C / 4) % 7;
int L = I - J;
int monat = 3 + (L + 40) / 44;
int tag = L + 28 - 31 * (monat / 4);

DateTime ostersonntag = new DateTime(jahr, monat, tag);
DateTime karfreitag = ostersonntag.AddDays(-2);
DateTime ostermontag = ostersonntag.AddDays(1);

Console.WriteLine("Karfreitag im Jahr {0} ist am: {1}", jahr, karfreitag.ToString("dd.MM."));
Console.WriteLine("Ostersonntag im Jahr {0} ist am: {1}", jahr, ostersonntag.ToString("dd.MM."));
Console.WriteLine("Ostermontag im Jahr {0} ist am: {1}", jahr, ostermontag.ToString("dd.MM."));

Console.ReadKey();