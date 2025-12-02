// Temperaturumrechner (ohne Schleife)

Console.WriteLine("Temperaturumrechner");
Console.WriteLine("[1] Celsius -> Fahrenheit");
Console.WriteLine("[2] Fahrenheit -> Celsius");
Console.Write("Deine Auswahl: ");

string input = Console.ReadLine();
int auswahl = Convert.ToInt32(input);

Console.WriteLine();

switch (auswahl)
{
    case 1:
        Console.Write("Gib die Temperatur in Celsius ein: ");
        input = Console.ReadLine();
        double celsius = Convert.ToDouble(input);
        double fahrenheit = celsius * 9 / 5 + 32;
        Console.WriteLine($"{celsius} °C entspricht {fahrenheit} °F");
        break;

    case 2:
        Console.Write("Gib die Temperatur in Fahrenheit ein: ");
        input = Console.ReadLine();
        fahrenheit = Convert.ToDouble(input);
        celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"{fahrenheit} °F entspricht {celsius} °C");
        break;

    default:
        Console.WriteLine("Ungültige Auswahl!");
        break;
}
