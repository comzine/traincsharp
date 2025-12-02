# 💡 Hint 2: Technische Details

> **Ziel dieses Hints:** Die technischen Konzepte erklären, die du brauchst.

## 3D-Arrays verstehen

Ein 3D-Array ist wie ein **Regal mit Schubladen**, die wiederum Fächer haben:

```
Array[monat, tag, stunde]
         ↓      ↓     ↓
      Regal  Schublade  Fach
```

### Deklaration

```csharp
float[,,] messwerte = new float[12, 31, 24];
//                            ↑   ↑   ↑
//                         Monate Tage Stunden
```

### Zugriff auf einen Wert

```csharp
// Wert für Januar, 1. Tag, 0:00 Uhr
float wert = messwerte[0, 0, 0];

// Wert für März, 15. Tag, 14:00 Uhr
float wert = messwerte[2, 14, 14];
//                     ↑   ↑   ↑
//            März=Index 2  |   14 Uhr
//                    15. Tag = Index 14
```

**Wichtig:** Indizes beginnen bei 0!
- Januar = Index 0, Dezember = Index 11
- 1. Tag = Index 0, 31. Tag = Index 30
- 0:00 Uhr = Index 0, 23:00 Uhr = Index 23

## Verschachtelte Schleifen

Um durch alle Werte zu gehen, brauchst du **drei Schleifen**:

```
Für jeden Monat:
    Für jeden Tag:
        Für jede Stunde:
            → Tu etwas mit dem Wert
```

### Die GetLength()-Methode

Statt die Größe hardcoded zu schreiben, nutze `GetLength()`:

```csharp
messwerte.GetLength(0)  // → 12 (Anzahl Monate)
messwerte.GetLength(1)  // → 31 (Anzahl Tage)
messwerte.GetLength(2)  // → 24 (Anzahl Stunden)
```

## Zeitraum-Berechnung

**13. August bis 16. September:**

| Datum | Monat-Index | Tag-Index |
|-------|-------------|-----------|
| 13. August | 7 | 12 |
| 16. September | 8 | 15 |

Du musst also:
- August (Index 7): Ab Tag 12 bis Tag 30
- September (Index 8): Ab Tag 0 bis Tag 15

## Extremwerte finden

Um den kleinsten Wert zu finden:

1. Nimm den ersten Wert als "bisheriges Minimum"
2. Gehe durch alle Werte
3. Wenn ein Wert kleiner ist → neues Minimum gefunden
4. Merke dir auch die Position (Monat, Tag, Stunde)

---

📖 **Grundlagen vergessen?**
- [Arrays in C#](./BASICS-ARRAYS.md)
- [Schleifen in C#](./BASICS-LOOPS.md)

⬅️ [Zurück zu Hint 1](./HINT-1.md) | ➡️ [Weiter zu Hint 3: Code-Beispiele](./HINT-3.md)
