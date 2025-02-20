public class IPAddress
{
  // Feld für die IP-Adresse als Array von BinaryNumber
  private BinaryNumber[] octets;

  // Konstruktor
  public IPAddress(string ipString)
  {
    octets = new BinaryNumber[4];
    string[] octetStrings = ipString.Split('.');

    // Prüfe ob genau 4 Oktette vorhanden sind
    if (octetStrings.Length != 4)
    {
      throw new ArgumentException("IP-Adresse muss aus 4 Oktetten bestehen");
    }

    // Konvertiere und validiere jedes Oktett
    for (int i = 0; i < 4; i++)
    {
      int value = int.Parse(octetStrings[i]);
      if (!ValidateOctet(value))
      {
        throw new ArgumentException($"Oktett {i + 1} ist ungültig (Wert: {value})");
      }
      octets[i] = new BinaryNumber(value);
    }
  }

  // Standard ToString-Methode
  public override string ToString()
  {
    string[] decimalOctets = new string[4];
    for (int i = 0; i < 4; i++)
    {
      decimalOctets[i] = octets[i].ToDecimal().ToString();
    }
    return string.Join(".", decimalOctets);
  }

  // ToString-Methode mit Format-Option
  public string ToString(string format)
  {
    switch (format?.ToLower())
    {
      case "binary":
        string[] binaryOctets = new string[4];
        for (int i = 0; i < octets.Length; i++)
        {
          binaryOctets[i] = octets[i].ToString(8);  // 8 Bit pro Oktett
        }
        return string.Join(".", binaryOctets);

      default:
        return ToString();
    }
  }

  // Validierung eines Oktetts
  private bool ValidateOctet(int value)
  {
    return value >= 0 && value <= 255;
  }
}
