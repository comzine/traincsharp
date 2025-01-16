string input;
do
{
  Console.WriteLine("1. Konvertierung von Dezimal zu Dual");
  Console.WriteLine("2. Konvertierung von Dual zu Dezimal");
  Console.WriteLine("3. Beenden");
  Console.Write("Ihre Wahl: ");
  input = Console.ReadLine();
  switch (input)
  {
    case "1":
      Console.Write("Bitte geben Sie eine Dezimalzahl ein: ");
      int dez = Convert.ToInt32(Console.ReadLine());
      int[] binary = ConvertDezToDual(dez);
      Console.Write("Die Dualzahl lautet: ");
      PrintArray(binary);
      break;
    case "2":
      int[] binaryArray = InputDualZahl();
      int dezimal = ConvertDualToDez(binaryArray);
      Console.WriteLine("Die Dezimalzahl lautet: " + dezimal);
      break;
    case "3":
      Environment.Exit(0);
      break;
    default:
      Console.WriteLine("Ungültige Eingabe!");
      break;
  }
} while (input != "3");


static int[] ConvertDezToDual(int number)
{
  int[] binary = new int[32];
  int i = binary.Length - 1;
  while (number > 0)
  {
    binary[i] = number % 2;
    number = number / 2;
    i--;
  }
  return binary;
}

static int ConvertDualToDez(int[] binary)
{
  int number = 0;
  int power = 0;
  for (int i = binary.Length - 1; i >= 0; i--)
  {
    number += binary[i] * Potenz(2, power);
    power++;
  }
  return number;
}

static void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i]);
  }
  Console.WriteLine();
}

static int[] InputDualZahl()
{
  Console.Write("Bitte geben Sie eine Dualzahl ein: ");
  string dual = Console.ReadLine();
  int[] binaryArray = new int[dual.Length];
  for (int i = 0; i < dual.Length; i++)
  {
    binaryArray[i] = Convert.ToInt32(dual[i].ToString());
  }
  return binaryArray;
}

static int Potenz(int basis, int exponent)
{
  int ergebnis = 1;
  for (int i = 0; i < exponent; i++)
  {
    ergebnis *= basis;
  }
  return ergebnis;
}