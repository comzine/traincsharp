public class IPAddress
{
  // Feld für die IP-Adresse
  private int[] octets;

  // Konstruktor
  public IPAddress(string ipString)
  {
    octets = new int[4];
    string[] octetStrings = ipString.Split('.');
    for (int i = 0; i < 4; i++)
    {
      octets[i] = int.Parse(octetStrings[i]);
    }
  }

  // Überschreiben der ToString()-Methode
  public override string ToString()
  {
    return string.Join(".", octets);
  }

  // Optional: Weitere hilfreiche Methoden
  private bool ValidateOctet(int value)
  {
    return value >= 0 && value <= 255;
  }
}