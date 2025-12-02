# 💡 Hint 4: Lösungsansatz

> **⚠️ Achtung:** Dieser Hint zeigt fast die komplette Lösung. Versuche zuerst, mit den anderen Hints selbst zu arbeiten!

## Programmstruktur

```csharp
// 1. Array erstellen
float[,,] messwerte = new float[12, 31, 24];
Random random = new Random();

// 2. Mit Zufallswerten füllen
for (int monat = 0; monat < messwerte.GetLength(0); monat++)
{
    for (int tag = 0; tag < messwerte.GetLength(1); tag++)
    {
        for (int stunde = 0; stunde < messwerte.GetLength(2); stunde++)
        {
            messwerte[monat, tag, stunde] = /* Zufallswert 0-15 */;
        }
    }
}

// 3. Korrektur für 13. August bis 16. September
// August (Index 7): Tag 12 bis 30
// September (Index 8): Tag 0 bis 15
/* Hier zwei Schleifen-Blöcke für beide Monate */

// 4. Ausgabe März bis Juni (Index 2 bis 5)
for (int monat = 2; monat <= 5; monat++)
{
    /* Verschachtelte Schleifen für Tag und Stunde */
}

// 5. Extremwerte finden
float minimum = messwerte[2, 0, 0];
float maximum = messwerte[2, 0, 0];
int minMonat = 2, minTag = 0, minStunde = 0;
int maxMonat = 2, maxTag = 0, maxStunde = 0;

for (int monat = 2; monat <= 5; monat++)
{
    for (int tag = 0; tag < messwerte.GetLength(1); tag++)
    {
        for (int stunde = 0; stunde < messwerte.GetLength(2); stunde++)
        {
            float wert = messwerte[monat, tag, stunde];

            if (wert < minimum)
            {
                minimum = wert;
                minMonat = monat;
                minTag = tag;
                minStunde = stunde;
            }

            if (wert > maximum)
            {
                /* Analog für Maximum */
            }
        }
    }
}

// 6. Durchschnitt berechnen
float summe = 0;
int anzahl = 0;

/* Drei verschachtelte Schleifen über alle Monate/Tage/Stunden */

float durchschnitt = summe / anzahl;
```

## Die kniffligen Stellen

### Korrektur über zwei Monate

```csharp
// August: Ab 13. (Index 12) bis Ende des Monats
for (int tag = 12; tag < messwerte.GetLength(1); tag++)
{
    for (int stunde = 0; stunde < messwerte.GetLength(2); stunde++)
    {
        messwerte[7, tag, stunde] *= 1.1f;
    }
}

// September: Vom Anfang bis 16. (Index 15)
for (int tag = 0; tag <= 15; tag++)
{
    for (int stunde = 0; stunde < messwerte.GetLength(2); stunde++)
    {
        messwerte[8, tag, stunde] *= 1.1f;
    }
}
```

### Zufallswert zwischen 0 und 15

```csharp
messwerte[monat, tag, stunde] = (float)(random.NextDouble() * 15);
```

### Ausgabe mit korrekten Monatsnummern

```csharp
// Bei Ausgabe +1 rechnen, weil Index bei 0 beginnt
Console.WriteLine($"Monat: {monat + 1}, Tag: {tag + 1}, Stunde: {stunde}, Wert: {wert}");
```

## Häufige Fehler vermeiden

1. **Index-Fehler:** Denke daran, dass Arrays bei 0 beginnen!
   - Januar = 0, nicht 1
   - 1. Tag = Index 0, nicht 1

2. **Schleifengrenzen:** Bei `<=` vs `<` aufpassen
   - `tag <= 15` → Tag 0 bis 15 (16 Tage)
   - `tag < 15` → Tag 0 bis 14 (15 Tage)

3. **Float-Literal:** Bei Multiplikation `1.1f` nicht `1.1` (sonst double)

---

📖 **Grundlagen vergessen?**
- [Arrays in C#](./BASICS-ARRAYS.md)
- [Schleifen in C#](./BASICS-LOOPS.md)

⬅️ [Zurück zu Hint 3](./HINT-3.md) | 🏠 [Zurück zur Aufgabe](./README.md)
