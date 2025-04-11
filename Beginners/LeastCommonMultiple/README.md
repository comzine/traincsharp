# Übung: Primfaktorzerlegung und Kombinationen

## Ziel

Entwickle ein C#-Programm, das die Primfaktorzerlegung von Zahlen berechnet und verschiedene Operationen mit diesen Zerlegungen durchführen kann.

## Hintergrund

Die Primfaktorzerlegung ist ein grundlegendes Konzept in der Zahlentheorie. Jede natürliche Zahl größer als 1 kann als Produkt von Primzahlen dargestellt werden. Diese Darstellung ist eindeutig (bis auf die Reihenfolge der Faktoren).

## Neue Konzepte

### Dictionary

Ein `Dictionary` ist eine Sammlung von Schlüssel-Wert-Paaren in C#. Es funktioniert wie ein Wörterbuch:

- Du suchst nach einem Schlüssel (z.B. einem Wort) und bekommst einen Wert (z.B. die Definition) zurück
- Jeder Schlüssel kann nur einmal im Dictionary vorkommen
- Der Zugriff auf Werte ist sehr schnell

Beispiel für die Verwendung eines Dictionary:

```csharp
// Erstellen eines Dictionary mit int als Schlüssel und string als Wert
Dictionary<int, string> zahlenWörter = new Dictionary<int, string>();

// Hinzufügen von Schlüssel-Wert-Paaren
zahlenWörter.Add(1, "eins");
zahlenWörter.Add(2, "zwei");
// oder kürzer:
zahlenWörter[3] = "drei";

// Prüfen, ob ein Schlüssel existiert
if (zahlenWörter.ContainsKey(2)) {
    Console.WriteLine("Die 2 ist im Dictionary!");
}

// Wert für einen Schlüssel abrufen
string wort = zahlenWörter[2]; // wort = "zwei"

// Über alle Schlüssel-Wert-Paare iterieren
foreach (KeyValuePair<int, string> paar in zahlenWörter) {
    Console.WriteLine($"Zahl: {paar.Key}, Wort: {paar.Value}");
}
```

In unserem Programm verwenden wir ein Dictionary, um Primzahlen (als Schlüssel) und ihre entsprechenden Prime-Objekte (als Werte) zu speichern.

### CompareTo und IComparable

`IComparable` ist eine Schnittstelle (Interface), die eine Methode namens `CompareTo` definiert. Diese Methode wird verwendet, um Objekte miteinander zu vergleichen und sie in eine Reihenfolge zu bringen (z.B. für Sortierungen).

Die `CompareTo`-Methode gibt einen Integer-Wert zurück:

- Wenn das aktuelle Objekt kleiner als das Vergleichsobjekt ist: negativer Wert
- Wenn das aktuelle Objekt gleich dem Vergleichsobjekt ist: 0
- Wenn das aktuelle Objekt größer als das Vergleichsobjekt ist: positiver Wert

Beispiel für die Implementierung von IComparable:

```csharp
class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Alter { get; set; }

    // Vergleicht Personen nach ihrem Alter
    public int CompareTo(Person other)
    {
        return this.Alter.CompareTo(other.Alter);
    }
}

// Verwendung:
List<Person> personen = new List<Person>();
// ... Personen hinzufügen ...
personen.Sort(); // Sortiert automatisch nach Alter dank CompareTo
```

In unserem Programm implementiert die `Prime`-Klasse `IComparable<Prime>`, damit wir Primzahlen sortieren können.

## Anforderungen

### Klassendiagramm

```plaintext
+------------------------+       +---------------------------+
|         Prime          |       |    PrimeFactorization     |
+------------------------+       +---------------------------+
| - prime: int           |       | - primeFactors: Dictionary|
| - exp: int             |       |   <int, Prime>            |
+------------------------+       +---------------------------+
| + Prime(prime: int)    |       | + PrimeFactorization(n:   |
| + Prime(prime: int,    |       |   int)                    |
|   exp: int)            |       | + ToString(): string      |
| + GetPrime(): int      |       | + Calculate(): int        |
| + GetExp(): int        |       | + Combine(other:          |
| + IncrementExp(): void |       |   PrimeFactorization):    |
| + ToString(): string   |       |   PrimeFactorization      |
| + Calculate(): int     |       +---------------------------+
| + CompareTo(other:     |
|   Prime): int          |
+------------------------+

```

### 1. Klasse `Prime`

Implementiere eine Klasse `Prime`, die eine Primzahl mit ihrem Exponenten repräsentiert:

- Konstruktoren für Primzahlen mit und ohne Exponenten
- Methoden zum Abrufen der Primzahl und des Exponenten
- Eine Methode zum Inkrementieren des Exponenten
- Eine `override ToString()`-Methode, die die Primzahl mit ihrem Exponenten darstellt
- Eine `Calculate()`-Methode, die den Wert der Primzahl potenziert mit ihrem Exponenten berechnet
- Implementierung des `IComparable<Prime>`-Interfaces für die Sortierung von Primzahlen

### 2. Klasse `PrimeFactorization`

Implementiere eine Klasse `PrimeFactorization`, die die Primfaktorzerlegung einer Zahl repräsentiert:

- Einen Konstruktor, der die Primfaktorzerlegung einer gegebenen Zahl berechnet
- Eine `ToString()`-Methode, die die Primfaktorzerlegung als String darstellt
- Eine `Calculate()`-Methode, die den Wert der Primfaktorzerlegung berechnet

Die `Combine`-Methode wird dir bereits zur Verfügung gestellt:

```csharp
public PrimeFactorization Combine(PrimeFactorization other)
{
    Dictionary<int, Prime> combinedFactors = new Dictionary<int, Prime>();

    var keys1 = primeFactors.Keys.ToList();
    var keys2 = other.primeFactors.Keys.ToList();

    List<int> allKeys = keys1.Union(keys2).ToList();

    foreach (int key in allKeys)
    {
        Prime prime1 = primeFactors.ContainsKey(key) ? primeFactors[key] : null;
        Prime prime2 = other.primeFactors.ContainsKey(key) ? other.primeFactors[key] : null;

        if (prime1 != null && prime2 != null)
        {
            combinedFactors[key] = new Prime(key, int.Max(prime1.GetExp(), prime2.GetExp()));
        }
        else if (prime1 != null)
        {
            combinedFactors[key] = new Prime(prime1.GetPrime(), prime1.GetExp());
        }
        else if (prime2 != null)
        {
            combinedFactors[key] = new Prime(prime2.GetPrime(), prime2.GetExp());
        }
    }
    return new PrimeFactorization(combinedFactors);
}
```

Diese Methode kombiniert zwei Primfaktorzerlegungen, indem sie für jede Primzahl den größeren Exponenten auswählt.

### 3. Hauptprogramm

Implementiere ein Hauptprogramm, das:

- Die Primfaktorzerlegung von mindestens zwei Zahlen berechnet
- Diese Primfaktorzerlegungen kombiniert
- Die kombinierte Primfaktorzerlegung und ihren Wert ausgibt

## Beispiel

```csharp
PrimeFactorization pf1 = new PrimeFactorization(48); // 2^4 * 3
PrimeFactorization pf2 = new PrimeFactorization(18); // 2 * 3^2
PrimeFactorization combined = pf1.Combine(pf2);      // 2^4 * 3^2 = 144

Console.WriteLine($"Primfaktorzerlegung von 48: {pf1}");
Console.WriteLine($"Primfaktorzerlegung von 18: {pf2}");
Console.WriteLine($"Kombinierte Primfaktorzerlegung: {combined}");
Console.WriteLine($"Wert der kombinierten Primfaktorzerlegung: {combined.Calculate()}");
```

## Erweiterungen

1. **Größter gemeinsamer Teiler (GGT)**: Implementiere eine Methode, die den GGT zweier Zahlen mithilfe ihrer Primfaktorzerlegungen berechnet.
2. **Kleinstes gemeinsames Vielfaches (KGV)**: Implementiere eine Methode, die das KGV zweier Zahlen mithilfe ihrer Primfaktorzerlegungen berechnet.
3. **Benutzerinteraktion**: Erweitere das Programm um eine Benutzeroberfläche, die es dem Benutzer ermöglicht, Zahlen einzugeben und verschiedene Operationen auszuwählen.

## Hinweise

- Ein Dictionary ist perfekt für die Speicherung von Primfaktoren, da jede Primzahl nur einmal als Schlüssel vorkommen kann.
- Die `CompareTo`-Methode wird benötigt, um die Primzahlen in der Ausgabe in aufsteigender Reihenfolge anzuzeigen.
- Achte darauf, dass du verstehst, wie die `Combine`-Methode funktioniert, auch wenn du sie nicht selbst implementieren musst.
