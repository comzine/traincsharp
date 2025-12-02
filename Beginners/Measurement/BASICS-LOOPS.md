# 📚 Grundlagen: Schleifen in C#

> Diese Seite erklärt die Grundlagen von Schleifen. Wenn du Schleifen schon verstehst, geh zurück zur [Aufgabe](./README.md).

## Was ist eine Schleife?

Eine Schleife wiederholt Code, bis eine Bedingung erfüllt ist.

```csharp
// Ohne Schleife (mühsam)
Console.WriteLine(1);
Console.WriteLine(2);
Console.WriteLine(3);
Console.WriteLine(4);
Console.WriteLine(5);

// Mit Schleife (elegant)
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
```

## Die for-Schleife

Die `for`-Schleife ist ideal, wenn du weißt, **wie oft** etwas wiederholt werden soll.

### Aufbau

```csharp
for (Startwert; Bedingung; Schrittweite)
{
    // Code der wiederholt wird
}
```

### Beispiel erklärt

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
// Ausgabe: 0, 1, 2, 3, 4
```

| Teil | Bedeutung |
|------|-----------|
| `int i = 0` | Startwert: Zähler beginnt bei 0 |
| `i < 5` | Bedingung: Solange i kleiner 5 |
| `i++` | Schrittweite: Nach jedem Durchlauf i um 1 erhöhen |

### Ablauf

```
1. i = 0 → Ist 0 < 5? Ja → Code ausführen → i++
2. i = 1 → Ist 1 < 5? Ja → Code ausführen → i++
3. i = 2 → Ist 2 < 5? Ja → Code ausführen → i++
4. i = 3 → Ist 3 < 5? Ja → Code ausführen → i++
5. i = 4 → Ist 4 < 5? Ja → Code ausführen → i++
6. i = 5 → Ist 5 < 5? Nein → Schleife beenden
```

## Verschachtelte Schleifen

Eine Schleife **in** einer anderen Schleife.

### Beispiel: Multiplikationstabelle

```csharp
for (int zeile = 1; zeile <= 3; zeile++)
{
    for (int spalte = 1; spalte <= 3; spalte++)
    {
        int ergebnis = zeile * spalte;
        Console.Write($"{ergebnis}\t");
    }
    Console.WriteLine();  // Neue Zeile
}
```

**Ausgabe:**
```
1   2   3
2   4   6
3   6   9
```

### Wie funktioniert das?

```
zeile=1: spalte=1,2,3 → Ausgabe: 1 2 3
zeile=2: spalte=1,2,3 → Ausgabe: 2 4 6
zeile=3: spalte=1,2,3 → Ausgabe: 3 6 9
```

Die **innere Schleife** läuft komplett durch, bevor die **äußere Schleife** einen Schritt macht.

## Dreifach verschachtelte Schleifen

Für 3D-Arrays brauchst du drei Schleifen:

```csharp
for (int monat = 0; monat < 12; monat++)
{
    for (int tag = 0; tag < 31; tag++)
    {
        for (int stunde = 0; stunde < 24; stunde++)
        {
            // Dieser Code läuft 12 × 31 × 24 = 8928 mal!
            Console.WriteLine($"Monat {monat}, Tag {tag}, Stunde {stunde}");
        }
    }
}
```

## Wichtige Varianten

### Von hinten nach vorne zählen

```csharp
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}
// Ausgabe: 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0
```

### In Zweierschritten

```csharp
for (int i = 0; i < 10; i += 2)
{
    Console.WriteLine(i);
}
// Ausgabe: 0, 2, 4, 6, 8
```

### Nur Teil eines Bereichs

```csharp
// Nur März bis Juni (Index 2 bis 5)
for (int monat = 2; monat <= 5; monat++)
{
    Console.WriteLine($"Monat: {monat}");
}
// Ausgabe: 2, 3, 4, 5
```

## Mit Arrays kombinieren

### Array durchlaufen

```csharp
int[] zahlen = { 10, 20, 30, 40, 50 };

for (int i = 0; i < zahlen.Length; i++)
{
    Console.WriteLine(zahlen[i]);
}
```

### Array mit Werten füllen

```csharp
int[] zahlen = new int[5];

for (int i = 0; i < zahlen.Length; i++)
{
    zahlen[i] = i * 10;  // 0, 10, 20, 30, 40
}
```

### Summe berechnen

```csharp
int[] zahlen = { 10, 20, 30, 40, 50 };
int summe = 0;

for (int i = 0; i < zahlen.Length; i++)
{
    summe += zahlen[i];  // summe = summe + zahlen[i]
}

Console.WriteLine($"Summe: {summe}");  // 150
```

### Maximum finden

```csharp
int[] zahlen = { 5, 2, 9, 1, 7 };
int max = zahlen[0];  // Erstes Element als Startwert

for (int i = 1; i < zahlen.Length; i++)
{
    if (zahlen[i] > max)
    {
        max = zahlen[i];
    }
}

Console.WriteLine($"Maximum: {max}");  // 9
```

## Häufige Fehler

### 1. Off-by-One Fehler

```csharp
int[] zahlen = new int[5];  // Indizes 0, 1, 2, 3, 4

// ❌ FALSCH: i <= 5 greift auf Index 5 zu (existiert nicht!)
for (int i = 0; i <= 5; i++)

// ✅ RICHTIG: i < 5 stoppt bei Index 4
for (int i = 0; i < 5; i++)

// ✅ AUCH RICHTIG: Mit Length
for (int i = 0; i < zahlen.Length; i++)
```

### 2. Falsche Klammern bei verschachtelten Schleifen

```csharp
// ❌ FALSCH: Innere Schleife nicht in äußerer
for (int i = 0; i < 3; i++)
    Console.WriteLine("Äußere");
    for (int j = 0; j < 3; j++)  // Diese läuft nur 1x!
        Console.WriteLine("Innere");

// ✅ RICHTIG: Mit geschweiften Klammern
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Äußere");
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("Innere");
    }
}
```

### 3. Endlosschleife

```csharp
// ❌ FALSCH: i wird nie größer, Schleife läuft ewig
for (int i = 0; i < 10; )
{
    Console.WriteLine(i);
}

// ✅ RICHTIG: i++ nicht vergessen
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
```

---

🏠 [Zurück zur Aufgabe](./README.md)
