
long kreditBetrag; // Kreditbetrag in Eurocents
double zinsSatzInDezimal; // Zinssatz der Bank in Dezimalform
double tilgungSatzZuBeginnDezimal; // Tilgungssatz zu Beginn in Dezimalform

// Eingabe der Kreditdaten
Console.WriteLine("Bitte geben Sie den Kreditbetrag in Euro ein:");
kreditBetrag = Convert.ToInt64(Console.ReadLine()) * 100;
Console.WriteLine("Bitte geben Sie den Zinssatz der Bank in Prozent ein:");
zinsSatzInDezimal = Convert.ToDouble(Console.ReadLine()) / 100;
Console.WriteLine("Bitte geben Sie den anfänglichen Tilgungssatz in Prozent ein:");
tilgungSatzZuBeginnDezimal = Convert.ToDouble(Console.ReadLine()) / 100;

// Berechnung der monatlichen Rate
long monatsRate = (long)(kreditBetrag * zinsSatzInDezimal / 12 + kreditBetrag * tilgungSatzZuBeginnDezimal / 12);

// Ausgabe der monatlichen Rate
Console.WriteLine($"Die monatliche Rate beträgt {monatsRate / 100.0:F2} Euro.");

// Initialisierung des Monats
int monat = 1;

// Ausgabe Überschrift der Tabelle
Console.WriteLine($"{"Monat",12}\t{"Zinsen",8}\t{"Tilgung",8}\t{"Restschuld",12}\t{"Bereits bezahlt",12}");

while (kreditBetrag > 0)
{
  // Berechnung der Zinsen
  long zinsen = BerechneZinsen(kreditBetrag, zinsSatzInDezimal);

  // Berechnung der Tilgung
  long tilgung = BerechneTilgung(monatsRate, zinsen);

  // Reduzierung des Kreditbetrags um die Tilgung
  kreditBetrag = BerechneRestschuld(kreditBetrag, tilgung);

  if ((monat - 1) % 12 == 0)
  {
    Console.WriteLine($"Jahr {(monat - 1) / 12 + 1}");
  }

  // Ausgabe des Monats, Zinsen, Tilgung, Restschuld und bereits insgesamt bezahltem Betrag in Tabellenform
  Console.WriteLine($"{GetMonat(monat),12}\t{zinsen / 100.0,8:F2}\t{tilgung / 100.0,8:F2}\t{kreditBetrag / 100.0,12:F2}\t{(monat * monatsRate) / 100.0,12:F2}");

  // Erhöhung des Monats um 1
  monat++;
}

static long BerechneZinsen(long kreditBetrag, double zinsSatzInDezimal)
{
  return (long)(kreditBetrag * zinsSatzInDezimal / 12);
}

static long BerechneTilgung(double monatsRate, double zinsen)
{
  return (long)(monatsRate - zinsen);
}

static long BerechneRestschuld(long kreditBetrag, long tilgung)
{
  return kreditBetrag - tilgung;
}

static string GetMonat(int monat)
{
  switch (monat % 12)
  {
    case 1:
      return "Januar";
    case 2:
      return "Februar";
    case 3:
      return "März";
    case 4:
      return "April";
    case 5:
      return "Mai";
    case 6:
      return "Juni";
    case 7:
      return "Juli";
    case 8:
      return "August";
    case 9:
      return "September";
    case 10:
      return "Oktober";
    case 11:
      return "November";
    case 0:
      return "Dezember";
    default:
      return "";
  }
}