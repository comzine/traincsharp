int[] zahl = new int[20];
Random rnd = new Random();

for (int i = 0; i < zahl.Length; i++)
{
  zahl[i] = rnd.Next(1, 100);
}

int search = 0;
do
{
  Console.Write("Number to search for:");
  search = Convert.ToInt32(Console.ReadLine());

  if (FindValue(zahl, search, out int index))
  {
    Console.WriteLine($"The number {search} was found at index {index}.");
    break;
  }
  else
  {
    Console.WriteLine($"The number {search} was not found.");
  }
} while (search > 0);

static bool FindValue(int[] array, int search, out int index)
{
  index = -1;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] == search)
    {
      index = i;
      return true;
    }
  }
  return false;
}