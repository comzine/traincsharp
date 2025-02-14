# Übung: Zahlensystem-Konverter (Dezimal/Dual)

## Ziel

Entwickle ein Konsolenprogramm in C#, das die Konvertierung zwischen Dezimal- und Dualzahlen ermöglicht. Das Programm soll ein benutzerfreundliches Menüsystem bieten und präzise Berechnungen durchführen.

## Anforderungen

### 1. Menüsystem

Implementiere ein Auswahlmenü mit folgenden Optionen:

- Konvertierung: Dezimal → Dual
- Konvertierung: Dual → Dezimal
- Programm beenden

### 2. Konvertierungsfunktionen

#### Dezimal zu Dual (`ConvertDezToDual`)

- **Übergabeparameter**: Dezimalzahl (int)
- **Rückgabe**: Integer-Array mit 32 Binärziffern
- **Methode**: Division-Rest-Verfahren
- Berechnung erfolgt durch wiederholte Division durch 2
- Reste ergeben die Binärziffern (von rechts nach links)

#### Dual zu Dezimal (`ConvertDualToDez`)

- **Übergabeparameter**: Binärzahlen-Array
- **Rückgabe**: Dezimalzahl (int)
- **Methode**: Horner-Schema
- Berechnung der Potenzen von 2 und Summierung der Produkte

### 3. Hilfsfunktionen

#### Zu übernehmen

```csharp
static int[] InputDualZahl()
{
    Console.Write("Bitte geben Sie eine Dualzahl ein: ");
    string dual = Console.ReadLine();
    int[] binaryArray = new int[dual.Length];
    for (int i = 0; i < dual.Length; i++)
    {
        binaryArray[i] = Convert.ToInt32(dual[i].ToString());
    }
    return binaryArray;
}
```

#### Zu implementieren

- `PrintArray`: Ausgabe eines Zahlenarrays ohne Trennzeichen
- `Potenz`: Berechnung von [Potenzen](<https://de.wikipedia.org/wiki/Potenz_(Mathematik)#Nat%C3%BCrliche_Exponenten>) ohne Math.Pow

## Beispielinteraktion

```
1. Konvertierung von Dezimal zu Dual
2. Konvertierung von Dual zu Dezimal
3. Beenden
Ihre Wahl: 1
Bitte geben Sie eine Dezimalzahl ein: 42
Die Dualzahl lautet: 00000000000000000000000000101010

1. Konvertierung von Dezimal zu Dual
2. Konvertierung von Dual zu Dezimal
3. Beenden
Ihre Wahl: 2
Bitte geben Sie eine Dualzahl ein: 101010
Die Dezimalzahl lautet: 42
```

## Hinweise

- Nutze ein 32-Bit Ganzzahl Array für die binäre Darstellung
- Achte auf die korrekte Behandlung führender Nullen
- Verwende die vorgegebene InputDualZahl-Methode für Dualeingaben
- Das Programm soll erst beendet werden, wenn Option 3 gewählt wird
