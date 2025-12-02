# 📚 Grundlagen: Arrays in C#

> Diese Seite erklärt die Grundlagen von Arrays. Wenn du Arrays schon verstehst, geh zurück zur [Aufgabe](./README.md).

## Was ist ein Array?

Ein Array ist wie eine **nummerierte Liste** von Werten des gleichen Typs.

```csharp
// Statt einzelner Variablen:
int note1 = 2;
int note2 = 1;
int note3 = 3;

// Besser: Ein Array
int[] noten = { 2, 1, 3 };
```

## 1D-Array (Eindimensional)

### Deklaration und Initialisierung

```csharp
// Leeres Array mit 5 Plätzen
int[] zahlen = new int[5];

// Array mit Werten
int[] zahlen = { 10, 20, 30, 40, 50 };
```

### Zugriff auf Elemente

```csharp
int[] zahlen = { 10, 20, 30, 40, 50 };
//    Index:      0   1   2   3   4

int erstesElement = zahlen[0];  // → 10
int drittesElement = zahlen[2]; // → 30

zahlen[1] = 99;  // Ändert 20 zu 99
```

**⚠️ Wichtig:** Der Index beginnt bei **0**, nicht bei 1!

### Array-Länge

```csharp
int[] zahlen = { 10, 20, 30 };
int laenge = zahlen.Length;  // → 3
```

## 2D-Array (Zweidimensional)

Ein 2D-Array ist wie eine **Tabelle** mit Zeilen und Spalten.

### Deklaration

```csharp
// Tabelle mit 3 Zeilen und 4 Spalten
int[,] tabelle = new int[3, 4];

// Mit Werten
int[,] tabelle = {
    { 1, 2, 3, 4 },    // Zeile 0
    { 5, 6, 7, 8 },    // Zeile 1
    { 9, 10, 11, 12 }  // Zeile 2
};
```

### Zugriff

```csharp
int wert = tabelle[1, 2];  // Zeile 1, Spalte 2 → 7
tabelle[0, 0] = 99;        // Ändert erste Zelle
```

### Dimensionsgrößen

```csharp
int zeilen = tabelle.GetLength(0);   // → 3
int spalten = tabelle.GetLength(1);  // → 4
```

## 3D-Array (Dreidimensional)

Ein 3D-Array ist wie ein **Regal mit Schubladen und Fächern**.

### Deklaration

```csharp
// 2 Regale, 3 Schubladen, 4 Fächer
float[,,] regal = new float[2, 3, 4];
```

### Visualisierung

```
Regal 0:
┌─────────────────────────┐
│ [0,0,0] [0,0,1] [0,0,2] [0,0,3] │  Schublade 0
│ [0,1,0] [0,1,1] [0,1,2] [0,1,3] │  Schublade 1
│ [0,2,0] [0,2,1] [0,2,2] [0,2,3] │  Schublade 2
└─────────────────────────┘

Regal 1:
┌─────────────────────────┐
│ [1,0,0] [1,0,1] [1,0,2] [1,0,3] │  Schublade 0
│ [1,1,0] [1,1,1] [1,1,2] [1,1,3] │  Schublade 1
│ [1,2,0] [1,2,1] [1,2,2] [1,2,3] │  Schublade 2
└─────────────────────────┘
```

### Zugriff

```csharp
float wert = regal[0, 1, 2];  // Regal 0, Schublade 1, Fach 2
regal[1, 2, 3] = 5.5f;        // Setzt einen Wert
```

### Dimensionsgrößen

```csharp
int regale = regal.GetLength(0);     // → 2
int schubladen = regal.GetLength(1); // → 3
int faecher = regal.GetLength(2);    // → 4
```

## Durch Arrays iterieren

### 1D-Array

```csharp
int[] zahlen = { 10, 20, 30 };

for (int i = 0; i < zahlen.Length; i++)
{
    Console.WriteLine(zahlen[i]);
}
```

### 2D-Array

```csharp
int[,] tabelle = new int[3, 4];

for (int zeile = 0; zeile < tabelle.GetLength(0); zeile++)
{
    for (int spalte = 0; spalte < tabelle.GetLength(1); spalte++)
    {
        Console.WriteLine(tabelle[zeile, spalte]);
    }
}
```

### 3D-Array

```csharp
float[,,] daten = new float[12, 31, 24];

for (int i = 0; i < daten.GetLength(0); i++)
{
    for (int j = 0; j < daten.GetLength(1); j++)
    {
        for (int k = 0; k < daten.GetLength(2); k++)
        {
            Console.WriteLine(daten[i, j, k]);
        }
    }
}
```

## Häufige Fehler

### 1. Index außerhalb des Bereichs

```csharp
int[] zahlen = new int[5];  // Indizes 0-4
zahlen[5] = 10;  // ❌ FEHLER! Index 5 existiert nicht
```

### 2. Index beginnt bei 0

```csharp
int[] zahlen = { 10, 20, 30 };
// Das erste Element ist zahlen[0], nicht zahlen[1]!
```

### 3. Length vs GetLength

```csharp
int[] arr1D = new int[5];
arr1D.Length;        // ✅ Für 1D-Arrays

int[,] arr2D = new int[3, 4];
arr2D.GetLength(0);  // ✅ Für mehrdimensionale Arrays
arr2D.Length;        // Gibt Gesamtzahl (12), nicht Zeilen!
```

---

🏠 [Zurück zur Aufgabe](./README.md)
