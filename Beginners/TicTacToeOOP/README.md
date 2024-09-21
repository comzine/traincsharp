# Tic Tac Toe OOP

Dieses Projekt ist Teil der Anfänger-Übungen und implementiert das klassische Tic Tac Toe Spiel als Konsolenprogramm in C# unter Verwendung objektorientierter Programmierung (OOP).

## Beschreibung

Tic Tac Toe ist ein Spiel für zwei Spieler, die abwechselnd Felder in einem 3x3-Gitter mit ihren Zeichen (üblicherweise X und O) besetzen. Der Spieler, der es schafft, drei seiner Zeichen in einer horizontalen, vertikalen oder diagonalen Reihe zu platzieren, gewinnt das Spiel.

## Lernziele

- Anwendung von OOP-Prinzipien in C#
- Verwendung von Klassen und Objekten
- Implementierung von Kontrollstrukturen (if-Anweisungen, Schleifen)
- Arbeiten mit Methoden und Parameterübergabe
- Benutzereingabe und -ausgabe in der Konsole
- Grundlegende Spiellogik und Zustandsverwaltung

## Projektstruktur

Das Projekt besteht aus vier Hauptklassen:

1. `Program.cs`: Enthält die `Main`-Methode, die das Spiel startet.
2. `Game.cs`: Verwaltet den Spielablauf, einschließlich Spielerzüge und Gewinnbedingungen.
3. `Board.cs`: Repräsentiert das Spielfeld und seinen Zustand.
4. `Player.cs`: Repräsentiert einen Spieler im Spiel.

## Funktionen

1. Anzeige des Spielfelds
2. Eingabeaufforderung für Spielerzüge
3. Überprüfung auf gültige Züge
4. Überprüfung auf Gewinnbedingungen
5. Überprüfung auf Unentschieden
6. Wechsel zwischen Spielern

## Hinweise

- Das Spielfeld wird als 3x3-Matrix dargestellt, wobei die Zeichen `X`, `O` und ` ` (Leerzeichen) verwendet werden.
- Die Spieler werden durch die Zeichen `X` und `O` repräsentiert.
- Die Spieler geben ihre Züge durch die Eingabe von Zeilen- und Spaltenindizes an (z.B. `0 2`).
- Die Indizes beginnen bei 0 und enden bei 2.
- Das Spiel endet, wenn ein Spieler gewinnt oder das Spielfeld vollständig belegt ist.

## Herausforderung

Erweitern Sie das Spiel um zusätzliche Funktionen, wie zum Beispiel:

- Möglichkeit, gegen den Computer zu spielen
- Implementierung verschiedener Schwierigkeitsgrade für den Computer-Gegner
- Speichern und Laden von Spielständen
- Führen einer Gewinnstatistik

Viel Spaß beim Programmieren und Spielen!
