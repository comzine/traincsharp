class Program
{
  static void Main(string[] args)
  {
    try
    {
      Console.WriteLine("Bitte geben Sie eine IP-Adresse ein (Format: xxx.xxx.xxx.xxx):");
      string input = Console.ReadLine();

      IPAddress ip = new IPAddress(input);
      // ToString() wird hier automatisch aufgerufen
      Console.WriteLine($"Die eingegebene IP-Adresse lautet: {ip}");
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Fehler: {ex.Message}");
    }
  }
}