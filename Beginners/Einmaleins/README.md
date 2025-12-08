# Übung: Das Einmaleins (Verschachtelte Schleifen)

## Ziel

Lerne verschachtelte `for`-Schleifen (nested loops) in C# kennen. In dieser Übung wirst du verstehen, wie man Schleifen ineinander verschachtelt, um zweidimensionale Ausgaben wie das Einmaleins zu erzeugen.

## Was sind verschachtelte Schleifen?

Eine verschachtelte Schleife ist eine Schleife innerhalb einer anderen Schleife. Die innere Schleife wird bei jedem Durchlauf der äußeren Schleife komplett durchlaufen.

```csharp
for (int zeile = 1; zeile <= 3; zeile++)
{
    for (int spalte = 1; spalte <= 4; spalte++)
    {
        Console.Write("*");
    }
    Console.WriteLine(); // Neue Zeile nach jeder Zeile
}
```

Dieser Code gibt aus:
```
****
****
****
```

**Ablauf der Verschachtelung:**

1. Äußere Schleife startet mit `zeile = 1`
2. Innere Schleife läuft komplett durch (`spalte = 1, 2, 3, 4`) → gibt `****` aus
3. `Console.WriteLine()` macht einen Zeilenumbruch
4. Äußere Schleife geht zu `zeile = 2`
5. Innere Schleife läuft wieder komplett durch → gibt `****` aus
6. ...und so weiter

**Wichtig:** Die innere Schleife kann auf die Variable der äußeren Schleife zugreifen. Das ist der Schlüssel zum Einmaleins!

## Das Einmaleins verstehen

Beim Einmaleins multiplizieren wir jede Zahl von 1 bis 10 mit jeder anderen Zahl von 1 bis 10:

```
     1   2   3   4   5   6   7   8   9  10
     2   4   6   8  10  12  14  16  18  20
     3   6   9  12  15  18  21  24  27  30
    ...
```

- **Zeile 1**: 1×1, 1×2, 1×3, ... 1×10
- **Zeile 2**: 2×1, 2×2, 2×3, ... 2×10
- **Zeile 3**: 3×1, 3×2, 3×3, ... 3×10

## Anforderungen

Erstelle ein Programm, das das Einmaleins mit verschachtelten Schleifen generiert:

### 1. **Begrüßung und Größe erfragen**
   - Begrüße den Benutzer.
   - Frage nach der maximalen Zahl für das Einmaleins (z.B. 10 für das klassische Einmaleins).

### 2. **Einmaleins-Tabelle ausgeben**
   - Verwende zwei verschachtelte `for`-Schleifen.
   - Die äußere Schleife iteriert über die Zeilen (1 bis maxZahl).
   - Die innere Schleife berechnet und gibt die Produkte aus.

### 3. **Formatierte Ausgabe**
   - Verwende `Console.Write()` für die Zahlen innerhalb einer Zeile.
   - Verwende `Console.WriteLine()` für den Zeilenumbruch.
   - Formatiere die Zahlen so, dass sie ordentlich ausgerichtet sind (Tipp: `{0,4}` im Format-String).

## Code-Skelett

Hier ist ein grundlegendes Gerüst für dein Programm:

```csharp
namespace Einmaleins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Das Einmaleins ===\n");

            // Schritt 1: Maximale Zahl erfragen
            Console.Write("Bis zu welcher Zahl soll das Einmaleins gehen? ");
            string eingabe = Console.ReadLine();
            int maxZahl = Convert.ToInt32(eingabe);

            Console.WriteLine(); // Leerzeile

            // Schritt 2: Einmaleins mit verschachtelten Schleifen ausgeben
            // TODO: Äußere Schleife für die Zeilen (1 bis maxZahl)
            // for (...)
            // {
            //     TODO: Innere Schleife für die Spalten (1 bis maxZahl)
            //     for (...)
            //     {
            //         // Berechne das Produkt: zeile * spalte
            //         // Gib es formatiert aus mit Console.Write()
            //     }
            //     // Zeilenumbruch nach jeder Zeile
            //     Console.WriteLine();
            // }

            Console.WriteLine("\nDrücke eine Taste zum Beenden...");
            Console.ReadKey();
        }
    }
}
```

## Formatierung mit String.Format

Um Zahlen ordentlich auszurichten, kannst du formatierte Ausgabe verwenden:

```csharp
// Gibt die Zahl rechtsbündig in einem 4-Zeichen-Feld aus
Console.Write("{0,4}", zahl);

// Alternativ mit String-Interpolation:
Console.Write($"{zahl,4}");
```

**Beispiel:**
- `{0,4}` bedeutet: Das erste Argument (Index 0) wird in einem Feld von 4 Zeichen rechtsbündig ausgegeben.
- Die Zahl `5` wird als `   5` ausgegeben (3 Leerzeichen + Zahl).
- Die Zahl `12` wird als `  12` ausgegeben (2 Leerzeichen + Zahl).

## Tipps

- Die äußere Schleifenvariable repräsentiert die **Zeile** (den ersten Faktor).
- Die innere Schleifenvariable repräsentiert die **Spalte** (den zweiten Faktor).
- Das Produkt ist `zeile * spalte`.
- Vergiss den `Console.WriteLine()` nach der inneren Schleife nicht – sonst steht alles in einer Zeile!
- Die Formatierung `{0,4}` sorgt dafür, dass alle Zahlen 4 Zeichen breit sind und somit ordentlich untereinander stehen.

## Optional

- **Überschrift mit Spaltennummern:** Füge eine Kopfzeile hinzu, die die Spaltennummern (1-10) anzeigt.
- **Alternative Berechnung:** Statt `zeile * spalte` kannst du auch versuchen, das Produkt durch Addition zu berechnen (wie in der ursprünglichen Lösung: `i += j`).
- **Farbige Ausgabe:** Verwende `Console.ForegroundColor`, um bestimmte Zahlen (z.B. Quadratzahlen wie 1, 4, 9, 16...) farbig hervorzuheben.
- **Nur Dreieck:** Gib nur das obere oder untere Dreieck der Tabelle aus (ohne Wiederholungen).
