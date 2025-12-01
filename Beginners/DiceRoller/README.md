# Übung: Würfel-Simulator mit Zufallszahlen

## Ziel

Das Ziel dieser Übung ist es, ein Konsolenprogramm in C# zu erstellen, das verschiedene Würfelspiele simuliert. Dabei lernst du die Klasse `Random` kennen, um Zufallszahlen zu erzeugen. Das Programm kombiniert `for`-Schleifen mit dem Modulo-Operator und Zufallszahlen.

## Was ist die Random-Klasse?

Die `Random`-Klasse in C# ermöglicht es, Zufallszahlen zu erzeugen. Das ist nützlich für Spiele, Simulationen oder überall dort, wo Zufall eine Rolle spielt.

**Verwendung:**

```csharp
Random zufall = new Random();
int zufallszahl = zufall.Next(1, 7);  // Zufallszahl zwischen 1 und 6 (wie ein Würfel)
```

**Wichtig:**

- `new Random()` erstellt ein neues Random-Objekt
- `Next(min, max)` erzeugt eine Zufallszahl von `min` bis `max-1`
- Für einen Würfel (1-6): `Next(1, 7)` verwenden!

**Beispiel:**

```csharp
Random zufall = new Random();

// 5 Würfelwürfe simulieren
for (int i = 1; i <= 5; i++)
{
    int wurf = zufall.Next(1, 7);
    Console.WriteLine("Wurf " + i + ": " + wurf);
}
```

Dies könnte ausgeben:

```text
Wurf 1: 3
Wurf 2: 6
Wurf 3: 1
Wurf 4: 5
Wurf 5: 2
```

## Anforderungen

Erstelle ein Programm, das folgende Aufgaben löst:

### 1. **Einzelner Würfelwurf**

- Erstelle ein `Random`-Objekt am Anfang des Programms (vor allen Übungen).
- Würfle einmal mit einem 6-seitigen Würfel und gib das Ergebnis aus.

### 2. **Mehrere Würfelwürfe**

- Frage den Benutzer, wie oft er würfeln möchte.
- Verwende `Console.ReadLine()` und `Convert.ToInt32()` für die Eingabe.
- Verwende eine `for`-Schleife, um so oft zu würfeln.
- Gib jeden Wurf nummeriert aus (z.B. "Wurf 1: 4").

### 3. **Würfelsumme berechnen**

- Frage den Benutzer, wie viele Würfel er werfen möchte.
- Würfle entsprechend oft und summiere alle Ergebnisse.
- Gib am Ende die Gesamtsumme aus.
- Beispiel: Bei 3 Würfeln mit den Ergebnissen 2, 5, 3 ist die Summe 10.

### 4. **Gerade oder ungerade Würfe zählen**

- Frage den Benutzer, wie oft gewürfelt werden soll.
- Zähle mit einer `for`-Schleife, wie viele gerade und wie viele ungerade Zahlen gewürfelt wurden.
- Verwende den Modulo-Operator (`%`), um zu prüfen, ob eine Zahl gerade ist.
- Gib am Ende aus, wie viele gerade und ungerade Würfe es gab.

## Code-Skelett

Hier ist ein grundlegendes Gerüst für dein Programm:

```csharp
namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Würfel-Simulator ===\n");

            // Random-Objekt erstellen (nur einmal am Anfang!)
            Random zufall = new Random();

            // Aufgabe 1: Einzelner Würfelwurf
            Console.WriteLine("Aufgabe 1: Einzelner Würfelwurf");
            int wurf = zufall.Next(1, 7);
            Console.WriteLine("Du hast eine " + wurf + " gewürfelt!");

            Console.WriteLine(); // Leerzeile

            // Aufgabe 2: Mehrere Würfelwürfe
            Console.WriteLine("Aufgabe 2: Mehrere Würfelwürfe");
            Console.Write("Wie oft möchtest du würfeln? ");
            string input = Console.ReadLine();
            int anzahl = Convert.ToInt32(input);

            // TODO: Implementiere die for-Schleife für mehrere Würfe
            // for (...)
            // {
            //     int wurf = zufall.Next(1, 7);
            //     Console.WriteLine("Wurf " + ... + ": " + wurf);
            // }

            Console.WriteLine(); // Leerzeile

            // Aufgabe 3: Würfelsumme berechnen
            Console.WriteLine("Aufgabe 3: Würfelsumme berechnen");
            Console.Write("Wie viele Würfel möchtest du werfen? ");
            // TODO: Lies die Eingabe ein
            // TODO: Erstelle eine Variable für die Summe (vor der Schleife!)
            // TODO: Implementiere die for-Schleife und summiere alle Würfe
            // TODO: Gib die Gesamtsumme aus

            Console.WriteLine(); // Leerzeile

            // Aufgabe 4: Gerade oder ungerade zählen
            Console.WriteLine("Aufgabe 4: Gerade oder ungerade Würfe zählen");
            Console.Write("Wie oft soll gewürfelt werden? ");
            // TODO: Lies die Eingabe ein
            // TODO: Erstelle zwei Zähler-Variablen (geradeAnzahl und ungeradeAnzahl)
            // TODO: Implementiere die for-Schleife
            // TODO: Prüfe mit if und Modulo (%), ob die Zahl gerade ist
            // TODO: Erhöhe den entsprechenden Zähler
            // TODO: Gib am Ende beide Zähler aus
        }
    }
}
```

## Tipps

- Erstelle das `Random`-Objekt nur **einmal** am Anfang des Programms, nicht in jeder Schleife!
- Eine Zahl ist gerade, wenn `zahl % 2 == 0` (der Rest bei Division durch 2 ist 0).
- Eine Zahl ist ungerade, wenn `zahl % 2 == 1` (oder `!= 0`).
- Um Werte zu summieren, brauchst du eine Variable vor der Schleife: `int summe = 0;`
- In der Schleife dann: `summe = summe + wurf;` (oder kürzer: `summe += wurf;`)

## Optional

- Erweitere das Programm um einen 20-seitigen Würfel (W20, wie in Rollenspielen).
- Implementiere eine Aufgabe, die prüft, wie oft man würfeln muss, bis man eine 6 würfelt.
- Erstelle ein Spiel: Der Spieler würfelt 3 Mal, der Computer auch. Wer die höhere Summe hat, gewinnt!
- Simuliere das Würfeln von zwei Würfeln gleichzeitig und gib aus, ob es ein "Pasch" ist (beide Würfel zeigen die gleiche Zahl).
