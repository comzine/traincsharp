class Program
{
  static void Main(string[] args)
  {
    try
    {
      TestBinaryNumber();
      Console.WriteLine("\n" + new string('-', 50) + "\n");
      TestIPAddress();
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Ein Fehler ist aufgetreten: {ex.Message}");
    }

    Console.WriteLine("\nDrücken Sie eine Taste zum Beenden...");
    Console.ReadKey();
  }

  static void TestBinaryNumber()
  {
    Console.WriteLine("=== Test der BinaryNumber-Klasse ===\n");

    // Test: Konstruktor mit String
    Console.WriteLine("Binärzahl aus String erstellen:");
    Console.Write("Geben Sie eine Binärzahl ein (nur 0 und 1): ");
    string binary = Console.ReadLine();
    BinaryNumber number = new BinaryNumber(binary);
    Console.WriteLine($"Binär: {number}");
    Console.WriteLine($"Dezimal: {number.ToDecimal()}");
    Console.WriteLine($"8-Bit Format: {number.ToString(8)}");

    // Test: Konstruktor mit Dezimalzahl
    Console.WriteLine("\nBinärzahl aus Dezimalzahl erstellen:");
    Console.Write("Geben Sie eine Dezimalzahl ein: ");
    int dez;
    if (int.TryParse(Console.ReadLine(), out dez))
    {
      BinaryNumber decNumber = new BinaryNumber(dez);
      Console.WriteLine($"Binär: {decNumber}");
      Console.WriteLine($"8-Bit Format: {decNumber.ToString(8)}");
    }

    // Test: Addition
    Console.WriteLine("\nAddition von Binärzahlen:");
    BinaryNumber num1 = new BinaryNumber("1010"); // 10
    BinaryNumber num2 = new BinaryNumber("0110"); // 6
    BinaryNumber sum = num1.Add(num2);
    Console.WriteLine($"{num1} + {num2} = {sum} (Dezimal: {sum.ToDecimal()})");
  }

  static void TestIPAddress()
  {
    Console.WriteLine("=== Test der IPAddress-Klasse ===\n");

    // Test: IP-Adresse eingeben
    Console.Write("Geben Sie eine IP-Adresse ein (Format: xxx.xxx.xxx.xxx): ");
    string ipString = Console.ReadLine();
    IPAddress ip = new IPAddress(ipString);

    // Verschiedene Ausgabeformate
    Console.WriteLine("\nAusgabeformate:");
    Console.WriteLine($"Standard: {ip}");
    Console.WriteLine($"Binär: {ip.ToString("binary")}");

    // Test: Mehrere IP-Adressen
    Console.WriteLine("\nVordefinierte IP-Adressen:");
    TestIPAddressFormat("192.168.0.1");
    TestIPAddressFormat("10.0.0.1");
    TestIPAddressFormat("172.16.254.1");
  }

  static void TestIPAddressFormat(string ipString)
  {
    try
    {
      IPAddress ip = new IPAddress(ipString);
      Console.WriteLine($"\nIP: {ipString}");
      Console.WriteLine($"Dezimal: {ip}");
      Console.WriteLine($"Binär: {ip.ToString("binary")}");
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Fehler bei IP {ipString}: {ex.Message}");
    }
  }
}
