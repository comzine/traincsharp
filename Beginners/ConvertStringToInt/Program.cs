Console.WriteLine("Bitte geben Sie eine Zahl ein: ");
string input = Console.ReadLine();

int result = 0;

// Durchlaufen jedes Zeichens im String und Umwandlung in eine Zahl
for (int i = 0; i < input.Length; i++)
{
    if (input[i] < '0' || input[i] > '9')
    {
        Console.WriteLine("Fehler: Ungültige Eingabe. Bitte geben Sie nur Zahlen ein.");
        return;
    }
    result = result * 10 + (input[i] - '0');
}

Console.WriteLine($"Die umgewandelte Ganzzahl ist: {result}");
Console.ReadKey();