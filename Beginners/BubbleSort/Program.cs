double[] distancesFromMunich = new double[10];
Random random = new Random();
for (int i = 0; i < distancesFromMunich.Length; i++)
{
  distancesFromMunich[i] = random.NextDouble() * 1000;
}
PrintArray(distancesFromMunich);

BubbleSort(distancesFromMunich);

PrintArray(distancesFromMunich);

static void BubbleSort(double[] distances)
{
  for (int i = 0; i < distances.Length - 1; i++)
  {
    for (int j = 0; j < distances.Length - 1 - i; j++)
    {
      if (distances[j] > distances[j + 1])
      {
        double temp = distances[j];
        distances[j] = distances[j + 1];
        distances[j + 1] = temp;
      }
    }
  }
}

static void PrintArray(double[] distances)
{
  for (int i = 0; i < distances.Length; i++)
  {
    Console.WriteLine($"Distance {i + 1}: {distances[i]:F1}");
  }
}