# Übung: Tic-Tac-Toe Konsolenspiel

## Ziel

Entwickle ein Tic-Tac-Toe Spiel als Konsolenapplikation in C#. Das Spiel soll objektorientiert aufgebaut sein und die grundlegenden Spielregeln von Tic-Tac-Toe umsetzen.

## Lernziele

- Anwendung objektorientierter Programmierung (OOP)
- Verwendung von Properties in C#
- Implementierung von Spiellogik
- Erstellung einer interaktiven Konsolenanwendung

## Grundlagen

Tic-Tac-Toe ist ein klassisches Zwei-Spieler-Spiel auf einem 3×3-Spielfeld. Die Spieler setzen abwechselnd ihre Zeichen (X und O) auf freie Felder. Gewonnen hat, wer zuerst drei seiner Zeichen in einer Reihe, Spalte oder Diagonale platziert hat.

## Teilaufgabe 1: Spielfeld-Klasse erstellen

Erstelle eine Klasse `Board`, die das Spielfeld repräsentiert:

1. Implementiere ein 3×3-Array als Property, das den Zustand des Spielfelds speichert
2. Erstelle einen Konstruktor, der das Spielfeld initialisiert
3. Überschreibe die `ToString()`-Methode, um das Spielfeld in der Konsole darzustellen
4. Implementiere eine Methode `IsValid()`, die prüft, ob ein Zug gültig ist
5. Implementiere eine Methode `Set()`, die einen Zug auf dem Spielfeld setzt
6. Implementiere eine Methode `Won()`, die prüft, ob ein Spieler gewonnen hat
7. Implementiere eine Methode `Unentschieden()`, die prüft, ob das Spiel unentschieden ist

## Teilaufgabe 2: Spieler-Klasse erstellen

Erstelle eine Klasse `Player`, die einen Spieler repräsentiert:

1. Implementiere ein Property für das Spielerzeichen (X oder O)
2. Erstelle einen Konstruktor, der das Spielerzeichen initialisiert
3. Implementiere eine Methode `Spielerzug()`, die die Eingabe des Spielers einliest und zurückgibt

## Teilaufgabe 3: Spiel-Klasse erstellen

Erstelle eine Klasse `Game`, die das Spiel steuert:

1. Implementiere Properties für das Spielfeld und die Spieler
2. Erstelle einen Konstruktor, der das Spiel initialisiert und die Hauptspielschleife enthält
3. Implementiere die Spiellogik mit abwechselnden Zügen
4. Implementiere die Gewinnüberprüfung und Ausgabe des Spielergebnisses

## Teilaufgabe 4: Hauptprogramm

Erstelle eine `Program.cs`-Datei mit einer `Main`-Methode, die das Spiel startet.

## Hinweise zu Properties in C#

Properties sind ein wichtiges Konzept in C#, das den Zugriff auf Felder einer Klasse kontrolliert. Sie kombinieren Aspekte von Feldern und Methoden:

```csharp
public class ExampleClass
{
    // Automatisch implementiertes Property (Auto-Property)
    public int Value { get; private set; }

    // Property mit Backing Field
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
}
```

- `get`: Definiert, wie ein Wert gelesen wird
- `set`: Definiert, wie ein Wert geschrieben wird
- `private set`: Erlaubt nur innerhalb der Klasse das Setzen des Werts
- Auto-Properties: Vereinfachte Syntax, bei der der Compiler automatisch ein Backing Field erstellt

In diesem Projekt werden Properties verwendet, um:

1. Den Zustand des Spielfelds zu kapseln (`Board.Spielfeld`)
2. Das Spielerzeichen eines Spielers zu definieren (`Player.Zeichen`)
3. Referenzen auf das Spielfeld und die Spieler im Spiel zu verwalten (`Game.MyBoard`, `Game.MyPlayers`)

## Erweiterungsmöglichkeiten

Nach der Fertigstellung des Grundspiels kannst du folgende Erweiterungen implementieren:

1. **Fehlerbehandlung**: Verbessere die Eingabevalidierung, um ungültige Eingaben abzufangen
2. **KI-Gegner**: Implementiere einen computergesteuerten Gegner mit verschiedenen Schwierigkeitsstufen
3. **Spielstatistik**: Füge eine Funktion hinzu, die Spielstatistiken wie gewonnene/verlorene Spiele speichert
4. **Grafische Verbesserungen**: Verbessere die Konsolenausgabe mit Farben oder ASCII-Art
5. **Spielfeldgröße**: Erweitere das Spiel, um verschiedene Spielfeldgrößen zu unterstützen
6. **Speichern/Laden**: Implementiere Funktionen zum Speichern und Laden von Spielständen

## Abgabe

Reiche folgende Dateien ein:

- `Board.cs`
- `Player.cs`
- `Game.cs`
- `Program.cs`

Viel Erfolg bei der Umsetzung des Tic-Tac-Toe Spiels!
