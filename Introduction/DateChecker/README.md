# Datumsüberprüfungsprogramm

## Ziel der Übung

Entwickle ein Konsolenprogramm in C#, das eine Datumsüberprüfung durchführt. Der Benutzer soll `Tag`, `Monat` und `Jahr` separat eingeben. Das Programm soll überprüfen, ob das eingegebene Datum gültig ist, einschließlich der korrekten Handhabung von Schaltjahren.

## Anforderungen

### Benutzereingabe

- Fordere den Benutzer auf, den Tag (`day`), den Monat (`month`) und das Jahr (`year`) einzeln einzugeben.

### Überprüfung

- Überprüfe die Gültigkeit des eingegebenen Datums:
  - Der Tag sollte innerhalb des gültigen Bereichs für den gegebenen Monat liegen.
  - Beachte die unterschiedliche Anzahl von Tagen in den Monaten (28/29 für Februar, 30 oder 31 für die anderen).
  - Überprüfe, ob das Jahr ein Schaltjahr ist. Ein Schaltjahr ist ein Jahr, das durch 4 teilbar ist, außer es ist durch 100 teilbar, es sei denn, es ist auch durch 400 teilbar.

### Ausgabe

- Gib aus, ob das Datum gültig oder ungültig ist.
- Bei ungültigen Eingaben gib eine entsprechende Fehlermeldung aus.

### Hinweise

- Verwende eine `switch`-Kontrollstruktur für die Überprüfung.
- Beachte die Regeln für Schaltjahre genau, um eine korrekte Überprüfung zu gewährleisten.
- Achte darauf, dass dein Programm auch die Sonderfälle für den Monat Februar korrekt behandelt.

### Bonus

- Implementiere zusätzliche Funktionen, wie das Ausgeben des Wochentages für das eingegebene Datum.
