int[] betraege = { 0, 0, 5, 10, 200, 1000, 1000000 };

Random rnd = new Random();
int[] userNumbers = new int[6];
for (int i = 0; i < userNumbers.Length; i++)
{
  userNumbers[i] = InputNumberBetween(1, 49);
}

Console.Write($"Ihre Zahlen: ");
BubbleSort(userNumbers);
AusgabeArray(userNumbers);

int anzahlRunden = 0;
Console.WriteLine($"Wie viele Runden moechten Sie spielen? Eine Runde kostet 1,50 Euro.");
string eingabe = Console.ReadLine();
anzahlRunden = Convert.ToInt32(eingabe);

double gesamtGewonnen = 0;

for (int runde = 0; runde < anzahlRunden; runde++)
{
  gesamtGewonnen = gesamtGewonnen - 1.5;
  int[] drawnNumbers = DrawNumbers();
  int correctNumbers = CountCorrectNumbers(userNumbers, drawnNumbers);
  int wonAmount = GetWonAmount(correctNumbers);

  Console.Write($"Gezogene Zahlen: ");
  BubbleSort(drawnNumbers);
  AusgabeArray(drawnNumbers);

  Console.WriteLine($"Sie haben {wonAmount} Euro gewonnen.");
  gesamtGewonnen = gesamtGewonnen + wonAmount;
}

Console.WriteLine($"Sie haben in {anzahlRunden} Runden {gesamtGewonnen} Euro gewonnen.");

int InputNumberBetween(int min, int max)
{
  int result = 0;
  bool isValid = true;
  do
  {
    isValid = true;
    Console.WriteLine($"Bitte Zahl zw. {min} und {max} eingeben.");
    string eingabe = Console.ReadLine();
    try
    {
      result = Convert.ToInt32(eingabe);
    }
    catch
    {
      isValid = false;
    }
    if (result < min || result > max)
    {
      isValid = false;
    }
  } while (isValid == false);
  return result;
}

int[] DrawNumbers()
{
  int[] kugeln = new int[49];
  int anzahlGezogeneKugeln = 0;

  for (int i = 0; i < kugeln.Length; i++)
  {
    kugeln[i] = i + 1;
  }
  /*
  int ersterIndex = rnd.Next(0, 49);
  Tauschen(kugeln, ersterIndex, 48);
  int zweiterIndex = rnd.Next(0, 48);
  Tauschen(kugeln, zweiterIndex, 47);
  int dritterIndex = rnd.Next(0, 47);
  Tauschen(kugeln, dritterIndex, 46);
  */

  for (int i = 0; i < 6; i++)
  {
    int index = rnd.Next(0, 49 - i);
    Tauschen(kugeln, index, 48 - i);
  }

  int[] result = new int[6];
  for (int i = 0; i < result.Length; i++)
  {
    result[i] = kugeln[48 - i];
  }
  return result;
}

int CountCorrectNumbers(int[] numbers, int[] drawnNumbers)
{
  int correctNumbers = 0;
  for (int i = 0; i < numbers.Length; i++)
  {
    for (int j = 0; j < drawnNumbers.Length; j++)
    {
      if (numbers[i] == drawnNumbers[j])
      {
        correctNumbers++;
      }
    }
  }
  return correctNumbers;
}

/*
2 Richtige: 5€
3 Richtige: 20€
4 Richtige: 100€
5 Richtige: 1.000€
6 Richtige: 1.000.000€
*/
int GetWonAmount(int correctNumbers)
{
  return betraege[correctNumbers];
}

void Tauschen(int[] array, int index1, int index2)
{
  int tmp = array[index2];
  array[index2] = array[index1];
  array[index1] = tmp;
}

void AusgabeArray(int[] array)
{
  string ausgabe = string.Join(' ', array);
  Console.WriteLine(ausgabe);
}

void BubbleSort(int[] array)
{
  for (int j = 0; j < array.Length; j++)
  {
    for (int i = 0; i < array.Length - 1 - j; i++)
    {
      if (array[i] > array[i + 1])
      {
        Tauschen(array, i, i + 1);
      }
    }
  }
}