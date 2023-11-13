Console.WriteLine("Bitte geben Sie eine Zahl ein: ");
string input = Console.ReadLine();

// Überprüfen, ob die Eingabe nur aus Ziffern besteht
bool isNumeric = true;
for (int i = 0; i < input.Length; i++)
{
    if (!char.IsDigit(input[i]))
    {
        isNumeric = false;
        break;
    }
}


if (!isNumeric)
{
    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie nur Zahlen ein.");
    return;
}

int sum = 0;

// Durchlaufen jedes Zeichens im String
for (int i = 0; i < input.Length; i++)
{
    // Konvertieren des Zeichens in eine Zahl
    int digit = int.Parse(input[i].ToString());
    // Addieren der Zahl zur Summe
    sum += digit;
}

Console.WriteLine($"Die Quersumme von {input} ist: {sum}");
Console.ReadKey();