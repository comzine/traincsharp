string input, factorized = "";
int number;
do
{
    Console.WriteLine("Enter a number: ");
    input = Console.ReadLine();
} while (!int.TryParse(input, out number));

for (int i = 2; i <= number; i++)
{
    while (number % i == 0)
    {
        factorized += i + "*";
        number /= i;
    }
}
factorized = factorized.Remove(factorized.Length - 1);
Console.WriteLine($"The factorization of {input} is: {factorized}");
Console.ReadKey();