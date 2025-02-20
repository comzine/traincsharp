public class BinaryNumber
{
  private int[] bits;

  // Konstruktor für String-Eingabe (z.B. "1010")
  public BinaryNumber(string binary)
  {
    if (!ValidateBinary(binary))
    {
      throw new ArgumentException("Ungültige Binärzahl");
    }

    bits = new int[binary.Length];
    for (int i = 0; i < binary.Length; i++)
    {
      bits[i] = binary[i] == '1' ? 1 : 0;
    }
  }

  // Konstruktor für Dezimalzahl
  public BinaryNumber(int decimalNumber)
  {
    if (decimalNumber < 0)
    {
      throw new ArgumentException("Negative Zahlen sind nicht erlaubt");
    }

    if (decimalNumber == 0)
    {
      bits = new int[] { 0 };
      return;
    }

    // Temporäre Liste für die Bits
    List<int> tempBits = new List<int>();
    int number = decimalNumber;

    // Konvertiere zu Binär durch wiederholte Division
    while (number > 0)
    {
      tempBits.Insert(0, number % 2);
      number /= 2;
    }

    // Konvertiere Liste zu Array
    bits = tempBits.ToArray();
  }

  // Konvertiert die Binärzahl in eine Dezimalzahl
  public int ToDecimal()
  {
    int result = 0;
    int power = bits.Length - 1;

    for (int i = 0; i < bits.Length; i++)
    {
      if (bits[i] == 1)
      {
        result += (int)Math.Pow(2, power - i);
      }
    }

    return result;
  }

  // Überschreibt die Standard-ToString-Methode
  public override string ToString()
  {
    string result = "";
    for (int i = 0; i < bits.Length; i++)
    {
      result += bits[i].ToString();
    }
    return result;
  }

  // Gibt die Binärzahl als String mit fester Länge zurück
  public string ToString(int length)
  {
    if (length < bits.Length)
    {
      throw new ArgumentException("Angegebene Länge ist kleiner als die Binärzahl");
    }
    if (length < 0)
    {
      throw new ArgumentException("Länge darf nicht negativ sein");
    }

    return ToString().PadLeft(length, '0');
  }

  // Gibt das Bit an einer bestimmten Position zurück
  public int GetBit(int position)
  {
    if (position < 0 || position >= bits.Length)
    {
      throw new ArgumentException("Ungültige Position");
    }
    return bits[position];
  }

  // Gibt die Länge der Binärzahl zurück
  public int GetLength()
  {
    return bits.Length;
  }

  // Validiert einen Binär-String
  private bool ValidateBinary(string binary)
  {
    if (string.IsNullOrEmpty(binary))
    {
      return false;
    }

    foreach (char c in binary)
    {
      if (c != '0' && c != '1')
      {
        return false;
      }
    }

    return true;
  }

  // Optional: Methode zum Addieren zweier Binärzahlen
  public BinaryNumber Add(BinaryNumber other)
  {
    int maxLength = Math.Max(this.GetLength(), other.GetLength());
    int[] result = new int[maxLength + 1];  // +1 für möglichen Übertrag
    int carry = 0;

    // Auffüllen der kürzeren Zahl mit Nullen
    string num1 = this.ToString(maxLength);
    string num2 = other.ToString(maxLength);

    // Addition von rechts nach links
    for (int i = maxLength - 1; i >= 0; i--)
    {
      int sum = (num1[i] - '0') + (num2[i] - '0') + carry;
      result[i + 1] = sum % 2;
      carry = sum / 2;
    }
    result[0] = carry;

    // Konvertiere result zu String und erstelle neue BinaryNumber
    string resultString = "";
    bool leadingZeroFound = false;
    for (int i = 0; i < result.Length; i++)
    {
      if (result[i] == 1)
      {
        leadingZeroFound = true;
      }
      if (leadingZeroFound || i == result.Length - 1)
      {
        resultString += result[i].ToString();
      }
    }

    return new BinaryNumber(resultString);
  }

  // Optional: Methode zum Invertieren der Bits
  public void Invert()
  {
    for (int i = 0; i < bits.Length; i++)
    {
      bits[i] = 1 - bits[i];
    }
  }

  // Optional: Methoden zum Verschieben der Bits
  public void ShiftLeft(int positions)
  {
    if (positions < 0)
    {
      throw new ArgumentException("Negative Verschiebung nicht erlaubt");
    }

    int[] newBits = new int[bits.Length + positions];
    for (int i = 0; i < bits.Length; i++)
    {
      newBits[i] = bits[i];
    }
    bits = newBits;
  }

  public void ShiftRight(int positions)
  {
    if (positions < 0)
    {
      throw new ArgumentException("Negative Verschiebung nicht erlaubt");
    }
    if (positions >= bits.Length)
    {
      bits = new int[] { 0 };
      return;
    }

    int[] newBits = new int[bits.Length - positions];
    for (int i = 0; i < newBits.Length; i++)
    {
      newBits[i] = bits[i + positions];
    }
    bits = newBits;
  }
}
