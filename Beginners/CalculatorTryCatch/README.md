# Übung: Konsolentaschenrechner mit Fehlerbehandlung

## Ziel

Entwickle einen Konsolentaschenrechner in C#, der grundlegende arithmetische Operationen ausführen kann und dabei robust mit möglichen Fehleingaben umgeht.

## Anforderungen

### 1. Benutzereingabe

- Implementiere eine Eingabeaufforderung für zwei Dezimalzahlen
- Stelle eine Auswahl der verfügbaren Operatoren (+, -, \*, /) bereit
- Ermögliche dem Benutzer mehrere Berechnungen nacheinander durchzuführen

### 2. Berechnungsfunktionen

- Erstelle eine `Calculate`-Methode, die folgende Operationen unterstützt:
  - Addition (+)
  - Subtraktion (-)
  - Multiplikation (\*)
  - Division (/)
- Gib das Ergebnis mit entsprechendem Rechenweg aus

### 3. Fehlerbehandlung

Implementiere Fehlerbehandlung für folgende Fälle:

- Ungültige Zahleneingaben (FormatException)
- Division durch Null (DivideByZeroException)
- Zahlen außerhalb des gültigen Wertebereichs (OverflowException)
- Ungültige Operatoren
- Allgemeine Ausnahmen mit Ausgabe der Fehlermeldung

### 4. Programmsteuerung

- Frage nach jeder Berechnung, ob eine weitere Berechnung durchgeführt werden soll
- Beende das Programm sauber mit einer Abschlussmeldung

## Beispielausgabe

```
Welcome to the Calculator!

Please enter the first number: 10,5
Please enter the second number: 5,2
Please choose an operator (+, -, *, /): +

Result: 10,5 + 5,2 = 15,7

Do you want to perform another calculation? (y/n): n

Program terminated.
```

## Hinweise

- Verwende den `decimal`-Datentyp für präzise Berechnungen
- Nutze `try-catch`-Blöcke für die Fehlerbehandlung
- Implementiere eine Schleife für wiederholte Berechnungen
- Achte auf benutzerfreundliche Fehlermeldungen

## Erweiterungsmöglichkeiten

- Erweitere die Funktionalität um zusätzliche mathematische Operationen (z.B. Potenzierung, Wurzel)
- Füge eine Verlaufsanzeige der letzten Berechnungen hinzu
- Implementiere eine Möglichkeit, mit dem Ergebnis weiterzurechnen
- Füge eine Option zum Löschen der Konsole zwischen den Berechnungen hinzu
