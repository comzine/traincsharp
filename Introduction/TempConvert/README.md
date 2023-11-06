# Temperaturumrechner

## Ziel der Übung
Entwickle ein Konsolenprogramm in C#, das Temperaturen zwischen Celsius und Fahrenheit umrechnen kann.

## Anforderungen

### Menü
- Zeige ein Menü mit folgenden Optionen:
  - `[1]` Umrechnung von Celsius nach Fahrenheit
  - `[2]` Umrechnung von Fahrenheit nach Celsius
- Ermögliche dem Benutzer die Auswahl der Umrechnungsrichtung.

### Benutzereingabe
- Fordere den Benutzer auf, die Umrechnungsoption und die zu konvertierende Temperatur einzugeben.

### Berechnung und Ausgabe
- Führe die gewählte Umrechnung mithilfe der entsprechenden Formel durch:
  - Von Celsius in Fahrenheit: `F = C × 9/5 + 32`
  - Von Fahrenheit in Celsius: `C = (F - 32) × 5/9`
- Gib das Ergebnis auf dem Bildschirm aus.

### Schleife
- Nutze eine Schleife, um das Programm so lange auszuführen, bis der Benutzer sich entscheidet, es zu beenden.
- Nach jeder Umrechnung sollte das Menü erneut angezeigt werden, um weitere Umrechnungen zu ermöglichen.

## Hinweise
- Stelle sicher, dass die Eingaben des Benutzers gültig sind und führe gegebenenfalls eine Fehlerbehandlung durch.
- Verwende `Convert.ToInt32()` oder ähnliche Methoden, um die Benutzereingabe in eine Zahl umzuwandeln.
- Beende das Programm sauber mit einer Abschiedsnachricht, wenn der Benutzer dies wünscht.
