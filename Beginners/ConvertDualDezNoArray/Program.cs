int dezimalzahl;
int[] bin = new int[20]; // Platz für 8 Ganzzahlen -> bin[0] bis bin[7]

System.Console.WriteLine("Zahlenumwandlung");
System.Console.WriteLine("================");
System.Console.WriteLine();

System.Console.WriteLine("Auswahlmenü");
System.Console.WriteLine("============");
System.Console.WriteLine("1. Dezimalzahl in Binärzahl umwandeln");
System.Console.WriteLine("2. Binärzahl in Dezimalzahl umwandeln");
System.Console.Write("Ihre Wahl: ");
int auswahl = int.Parse(System.Console.ReadLine());

switch (auswahl)
{
  case 1:
    System.Console.Write("Bitte geben Sie eine Dezimalzahl zwischen 0 und 2^20-1 ein: ");
    dezimalzahl = int.Parse(System.Console.ReadLine());

    // dezimalzahl = 42

    for (int i = 0; i < 20; i++)
    {
      bin[i] = dezimalzahl % 2;
      dezimalzahl = dezimalzahl / 2;
    }

    System.Console.Write("Binärzahl: ");
    bool firstOne = false;
    for (int i = 19; i >= 0; i--)
    {
      if (bin[i] == 1 || firstOne)
      {
        Console.Write(bin[i]);
        firstOne = true;
      }
    }
    if (firstOne == false)
    {
      Console.Write("0");
    }
    System.Console.WriteLine();
    break;
  case 2:
    System.Console.Write("Binärzahl: ");
    break;
  default:
    System.Console.WriteLine("Falsche Eingabe!");
    break;
}