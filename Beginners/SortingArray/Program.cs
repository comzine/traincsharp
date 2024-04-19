double[] distancesFromMunich = new double[10];
Random random = new Random();
for (int i = 0; i < distancesFromMunich.Length; i++)
{
  distancesFromMunich[i] = random.NextDouble() * 1000;
}
PrintArray(distancesFromMunich);

BubbleSort(distancesFromMunich);
// MergeSort(distancesFromMunich);
// QuickSort(distancesFromMunich);

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

// Additional MergeSort methods

static void MergeSort(double[] distances)
{
  if (distances.Length <= 1)
  {
    return;
  }

  int middle = distances.Length / 2;
  double[] left = new double[middle];
  double[] right = new double[distances.Length - middle];

  for (int i = 0; i < middle; i++)
  {
    left[i] = distances[i];
  }

  for (int i = middle; i < distances.Length; i++)
  {
    right[i - middle] = distances[i];
  }

  MergeSort(left);
  MergeSort(right);

  Merge(distances, left, right);
}

static void Merge(double[] distances, double[] left, double[] right)
{
  int i = 0;
  int j = 0;
  int k = 0;

  while (i < left.Length && j < right.Length)
  {
    if (left[i] < right[j])
    {
      distances[k] = left[i];
      i++;
    }
    else
    {
      distances[k] = right[j];
      j++;
    }
    k++;
  }

  while (i < left.Length)
  {
    distances[k] = left[i];
    i++;
    k++;
  }

  while (j < right.Length)
  {
    distances[k] = right[j];
    j++;
    k++;
  }
}

// Additional QuickSort methods

static void QuickSort(double[] distances)
{
  QuickSortRecursive(distances, 0, distances.Length - 1);
}

static void QuickSortRecursive(double[] distances, int low, int high)
{
  if (low < high)
  {
    int pivotIndex = Partition(distances, low, high);
    QuickSortRecursive(distances, low, pivotIndex - 1);
    QuickSortRecursive(distances, pivotIndex + 1, high);
  }
}

static int Partition(double[] distances, int low, int high)
{
  double pivot = distances[high];
  int i = low - 1;

  for (int j = low; j < high; j++)
  {
    if (distances[j] < pivot)
    {
      i++;
      Swap(distances, i, j);
    }
  }

  Swap(distances, i + 1, high);
  return i + 1;
}

static void Swap(double[] distances, int i, int j)
{
  double temp = distances[i];
  distances[i] = distances[j];
  distances[j] = temp;
}