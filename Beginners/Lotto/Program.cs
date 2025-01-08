Console.WriteLine("Lotto Simulator");

float wonAmount = 0;

int[] numbers = new int[6];

Console.WriteLine("Choose 6 numbers between 1 and 49");

for (int i = 0; i < 6; i++)
{
  numbers[i] = InputNumberBetween(1, 49);
}

Console.WriteLine("How many rounds should be simulated?");
int rounds = InputNumberBetween(1, int.MaxValue);

Console.WriteLine("You have to pay 1.50€ for each round.");
Console.WriteLine("So you have to pay " + rounds * 1.5 + "€");
wonAmount -= rounds * 1.5f;

for (int i = 0; i < rounds; i++)
{
  Console.WriteLine($"Round {i + 1}");

  int correctNumbers = CountCorrectNumbers(numbers, DrawNumbers());

  Console.WriteLine($"Correct numbers: {correctNumbers}");
  Console.WriteLine($"You won {GetWonAmount(correctNumbers)}€");
  wonAmount += GetWonAmount(correctNumbers);
}

Console.WriteLine($"You won {wonAmount}€");

int InputNumberBetween(int min, int max)
{
  int number = 0;
  bool validNumber = false;
  do
  {
    Console.Write($"Input a number between {min} and {max}: ");
    validNumber = int.TryParse(Console.ReadLine(), out number);
  } while (!validNumber || number < min || number > max);
  return number;
}

int[] DrawNumbers()
{
  Random random = new Random();
  int[] numbers = new int[6];
  for (int i = 0; i < 6; i++)
  {
    numbers[i] = random.Next(1, 50);
  }
  return numbers;
}

int CountCorrectNumbers(int[] numbers, int[] drawnNumbers)
{
  int correctNumbers = 0;
  for (int i = 0; i < 6; i++)
  {
    if (numbers.Contains(drawnNumbers[i]))
    {
      correctNumbers++;
    }
  }
  return correctNumbers;
}

int GetWonAmount(int correctNumbers)
{
  switch (correctNumbers)
  {
    case 0:
    case 1:
      return 0;
    case 2:
      return 5;
    case 3:
      return 20;
    case 4:
      return 100;
    case 5:
      return 1000;
    case 6:
      return 1000000;
    default:
      return 0;
  }
}