# Einfacher Taschenrechner

## Ziel der Übung

Entwickle ein Konsolenprogramm in C#, das grundlegende arithmetische Operationen (Addition, Subtraktion, Multiplikation, Division) zwischen zwei Zahlen ausführen kann.

## Anforderungen

### Menü

- Zeige ein Menü mit folgenden Optionen:
  - `[1]` Erste Zahl eingeben
  - `[2]` Operator eingeben
  - `[3]` Zweite Zahl eingeben
  - `[4]` Berechnung durchführen
  - `[5]` Programm beenden
- Ermögliche dem Benutzer die Auswahl aus dem Menü.

### Benutzereingabe

- Fordere den Benutzer auf, die erste Zahl, den Operator, die zweite Zahl und die Auswahl für die Berechnung einzugeben.

### Berechnung und Ausgabe

- Führe die Berechnung basierend auf dem gewählten Operator durch:
  - Addition: `+`
  - Subtraktion: `-`
  - Multiplikation: `*`
  - Division: `/`
- Gib das Ergebnis der Berechnung auf dem Bildschirm aus.

### Schleife

- Nutze eine Schleife, um das Programm so lange auszuführen, bis der Benutzer sich entscheidet, es zu beenden.
- Nach jeder Berechnung sollte das Menü erneut angezeigt werden, um weitere Berechnungen zu ermöglichen.

## Hinweise

- Stelle sicher, dass die Eingaben des Benutzers gültig sind und führe gegebenenfalls eine Fehlerbehandlung durch.
- Verwende `Convert.ToDouble()` oder ähnliche Methoden, um die Benutzereingabe in eine Zahl umzuwandeln.
- Implementiere eine Fehlerbehandlung für die Division durch Null und ungültige Operatoren.
- Beende das Programm sauber mit einer Abschiedsnachricht, wenn der Benutzer dies wünscht.
