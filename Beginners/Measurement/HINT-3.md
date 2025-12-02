# 💡 Hint 3: Code-Beispiele

> **Ziel dieses Hints:** Konkrete Code-Beispiele zeigen, die du anpassen kannst.

## Beispiel 1: 3D-Array erstellen und füllen

```csharp
// Array deklarieren
float[,,] daten = new float[12, 31, 24];

// Random-Objekt erstellen
Random random = new Random();

// Array mit Zufallswerten füllen
for (int monat = 0; monat < daten.GetLength(0); monat++)
{
    for (int tag = 0; tag < daten.GetLength(1); tag++)
    {
        for (int stunde = 0; stunde < daten.GetLength(2); stunde++)
        {
            // Zufallswert zwischen 0 und 15
            daten[monat, tag, stunde] = (float)(random.NextDouble() * 15);
        }
    }
}
```

## Beispiel 2: Werte in einem Bereich ändern

Angenommen, du willst alle Werte von **Mai (Index 4)** mit 1,5 multiplizieren:

```csharp
int zielMonat = 4; // Mai

for (int tag = 0; tag < daten.GetLength(1); tag++)
{
    for (int stunde = 0; stunde < daten.GetLength(2); stunde++)
    {
        daten[zielMonat, tag, stunde] *= 1.5f;
    }
}
```

## Beispiel 3: Werte ausgeben

```csharp
// Alle Werte von Februar (Index 1) ausgeben
int monat = 1;

for (int tag = 0; tag < daten.GetLength(1); tag++)
{
    for (int stunde = 0; stunde < daten.GetLength(2); stunde++)
    {
        float wert = daten[monat, tag, stunde];
        // +1 bei Ausgabe, weil Menschen ab 1 zählen
        Console.WriteLine($"Tag {tag + 1}, Stunde {stunde}: {wert}");
    }
}
```

## Beispiel 4: Maximum in einem 2D-Array finden

```csharp
int[,] zahlen = { {1, 5, 3}, {9, 2, 7} };

int maximum = zahlen[0, 0];  // Startwert
int maxZeile = 0;
int maxSpalte = 0;

for (int zeile = 0; zeile < zahlen.GetLength(0); zeile++)
{
    for (int spalte = 0; spalte < zahlen.GetLength(1); spalte++)
    {
        if (zahlen[zeile, spalte] > maximum)
        {
            maximum = zahlen[zeile, spalte];
            maxZeile = zeile;
            maxSpalte = spalte;
        }
    }
}

Console.WriteLine($"Maximum: {maximum} an Position [{maxZeile}, {maxSpalte}]");
```

## Beispiel 5: Durchschnitt berechnen

```csharp
float summe = 0;
int anzahl = 0;

for (int i = 0; i < daten.GetLength(0); i++)
{
    for (int j = 0; j < daten.GetLength(1); j++)
    {
        summe += daten[i, j];
        anzahl++;
    }
}

float durchschnitt = summe / anzahl;
Console.WriteLine($"Durchschnitt: {durchschnitt}");
```

## Beispiel 6: Bereich über zwei Monate

Wenn ein Zeitraum **zwei Monate** umfasst, brauchst du eine Fallunterscheidung:

```csharp
// Von 20. März bis 10. April
// März = Index 2, April = Index 3

// März: Ab Tag 19 (20. März = Index 19) bis Ende
for (int tag = 19; tag < 31; tag++)
{
    for (int stunde = 0; stunde < 24; stunde++)
    {
        // Tu etwas mit daten[2, tag, stunde]
    }
}

// April: Von Anfang bis Tag 9 (10. April = Index 9)
for (int tag = 0; tag <= 9; tag++)
{
    for (int stunde = 0; stunde < 24; stunde++)
    {
        // Tu etwas mit daten[3, tag, stunde]
    }
}
```

---

📖 **Grundlagen vergessen?**
- [Arrays in C#](./BASICS-ARRAYS.md)
- [Schleifen in C#](./BASICS-LOOPS.md)

⬅️ [Zurück zu Hint 2](./HINT-2.md) | ➡️ [Weiter zu Hint 4: Lösungsansatz](./HINT-4.md)
