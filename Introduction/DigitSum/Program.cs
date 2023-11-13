string input;
int sum = 0;

Console.WriteLine("Quersumme berechnen");
Console.WriteLine("Bitte geben Sie eine Zahl ein:");
input = Console.ReadLine();

for (int i = 0; i < input.Length; i++)
{
    if (input[i] >= '0' && input[i] <= '9')
    {
        sum += input[i] - '0';
    }
    else
    {
        Console.WriteLine("Fehler: Ungültige Eingabe!");
        Console.ReadKey();
        return;
    }
}
Console.WriteLine("Die Quersumme von {0} ist {1}", input, sum);
Console.ReadKey();
