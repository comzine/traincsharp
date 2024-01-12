int number = 0;
do
{
    Console.Write("Enter a number greater than 0 (smaller than 0 means exit): ");
    number = int.Parse(Console.ReadLine());
    if (number > 0)
    {
        int[] factors = Factorization(number);
        PrintFactors(factors);
    }

} while (number > 0);


static int[] Factorization(int number)
{
    int[] factors = new int[100];
    int factor = 2;
    int amountOfFactors = 0;
    while (number > 1)
    {
        if (number % factor == 0)
        {
            factors[amountOfFactors] = factor;
            amountOfFactors++;
            number /= factor;
        }
        else
        {
            factor++;
        }
    }
    int[] factorsToReturn = new int[amountOfFactors];
    for (int i = 0; i < amountOfFactors; i++)
    {
        factorsToReturn[i] = factors[i];
    }
    return factorsToReturn;
}

static void PrintFactors(int[] factors)
{
    for (int i = 0; i < factors.Length; i++)
    {
      Console.Write(factors[i]);
      if (i < factors.Length - 1)
      {
        Console.Write(" * ");
      }
    }
    Console.WriteLine();
}