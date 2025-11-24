# Übung: Einführung in For-Schleifen

## Ziel

Lerne die Grundlagen von `for`-Schleifen in C# kennen. In dieser Übung wirst du verstehen, wie man mit Schleifen wiederholte Aufgaben automatisiert und wie man über Zahlenfolgen iteriert.

## Was ist eine For-Schleife?

Eine `for`-Schleife ist eine Kontrollstruktur, die es ermöglicht, einen Codeblock mehrmals auszuführen. Sie besteht aus drei Teilen:

```csharp
for (Initialisierung; Bedingung; Inkrement)
{
    // Codeblock, der wiederholt ausgeführt wird
}
```

**Beispiel:**
```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Durchlauf: " + i);
}
```

Dieser Code gibt aus:
```
Durchlauf: 1
Durchlauf: 2
Durchlauf: 3
Durchlauf: 4
Durchlauf: 5
```

**Erklärung der drei Teile:**

1. **Initialisierung** (`int i = 1`): Wird einmal am Anfang ausgeführt. Hier wird die Schleifenvariable erstellt und mit einem Startwert versehen.

2. **Bedingung** (`i <= 5`): Wird vor jedem Durchlauf geprüft. Solange die Bedingung `true` ist, wird die Schleife fortgesetzt.

3. **Inkrement** (`i++`): Wird nach jedem Durchlauf ausgeführt. Hier wird die Schleifenvariable verändert (z.B. erhöht).

## Anforderungen

Erstelle ein Programm, das folgende Aufgaben mit `for`-Schleifen löst:

### 1. **Zahlen von 1 bis 10 ausgeben**
   - Verwende eine `for`-Schleife, um die Zahlen von 1 bis 10 auszugeben.
   - Jede Zahl soll in einer neuen Zeile erscheinen.

### 2. **Countdown erstellen**
   - Frage den Benutzer nach einer Startzahl.
   - Verwende `Console.ReadLine()` und `Convert.ToInt32()` für die Eingabe.
   - Erstelle einen Countdown von dieser Zahl bis 1.
   - Gib am Ende "Start!" aus.

### 3. **Summe berechnen**
   - Frage den Benutzer nach einer positiven Zahl.
   - Berechne die Summe aller Zahlen von 1 bis zu dieser Zahl.
   - Beispiel: Wenn der Benutzer 5 eingibt, berechne 1 + 2 + 3 + 4 + 5 = 15.

### 4. **Multiplikationstabelle**
   - Frage den Benutzer nach einer Zahl zwischen 1 und 10.
   - Gib die Multiplikationstabelle für diese Zahl aus (von 1 bis 10).
   - Beispiel für die Zahl 3:
     ```
     3 x 1 = 3
     3 x 2 = 6
     3 x 3 = 9
     ...
     3 x 10 = 30
     ```

## Code-Skelett

Hier ist ein grundlegendes Gerüst für dein Programm:

```csharp
namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Übung: For-Schleifen ===\n");

            // Aufgabe 1: Zahlen von 1 bis 10
            Console.WriteLine("Aufgabe 1: Zahlen von 1 bis 10");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(); // Leerzeile

            // Aufgabe 2: Countdown
            Console.WriteLine("Aufgabe 2: Countdown");
            Console.Write("Gib eine Startzahl ein: ");
            string input = Console.ReadLine();
            int startZahl = Convert.ToInt32(input);

            // TODO: Implementiere den Countdown mit einer for-Schleife
            // for (...)
            // {
            //     Console.WriteLine(...);
            // }
            // Console.WriteLine("Start!");

            Console.WriteLine(); // Leerzeile

            // Aufgabe 3: Summe berechnen
            Console.WriteLine("Aufgabe 3: Summe berechnen");
            Console.Write("Gib eine positive Zahl ein: ");
            // TODO: Lies die Eingabe ein und berechne die Summe

            Console.WriteLine(); // Leerzeile

            // Aufgabe 4: Multiplikationstabelle
            Console.WriteLine("Aufgabe 4: Multiplikationstabelle");
            Console.Write("Gib eine Zahl zwischen 1 und 10 ein: ");
            // TODO: Lies die Eingabe ein und gib die Multiplikationstabelle aus
        }
    }
}
```

## Tipps

- Die Schleifenvariable (meist `i`) ist nur innerhalb der Schleife gültig.
- Du kannst die Schleifenvariable auch rückwärts zählen lassen: `i--` statt `i++`.
- Die Bedingung bestimmt, wann die Schleife endet. Achte darauf, dass sie irgendwann `false` wird, sonst läuft die Schleife endlos!
- Um eine Variable innerhalb der Schleife zu verwenden (z.B. für eine Summe), musst du sie vor der Schleife initialisieren.

## Optional

- Erweitere das Programm um eine Aufgabe, die nur gerade oder ungerade Zahlen ausgibt.
- Implementiere eine Aufgabe, die die Fakultät einer Zahl berechnet (z.B. 5! = 1 × 2 × 3 × 4 × 5 = 120).
- Erstelle ein Programm, das ein Rechteck aus Sternen (*) mit vom Benutzer gewählter Breite und Höhe zeichnet.
