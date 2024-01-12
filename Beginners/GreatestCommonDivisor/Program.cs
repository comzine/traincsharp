Console.Write("Enter the number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];

for (int i = 0; i < n; i++)
{
  Console.Write($"Enter number {i + 1}: ");
  numbers[i] = Convert.ToInt32(Console.ReadLine());
}

int gcd = numbers[0];
for (int i = 1; i < n; i++)
{
  gcd = CalculateGCD(gcd, numbers[i]);
}

Console.WriteLine($"The Greatest Common Divisor is: {gcd}");


static int CalculateGCD(int a, int b)
{
  while (b != 0)
  {
    int temp = b;
    b = a % b;
    a = temp;
  }
  return a;
}