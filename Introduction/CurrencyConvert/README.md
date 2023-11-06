# Übung: Währungsumrechner mit Fehlerbehandlung

## Ziel der Übung

Erstelle ein Konsolenprogramm, das die Umrechnung zwischen verschiedenen Währungen ermöglicht und dabei robuste Fehlerbehandlung mittels `try-catch`-Blöcken implementiert.

## Anforderungen

### Menü

- Zeige ein Menü mit verschiedenen Währungen an, z.B.:
  - `[1]` EUR in USD
  - `[2]` USD in EUR
  - `[3]` EUR in GBP
  - `[4]` GBP in EUR
- Lasse den Benutzer die gewünschte Umrechnung auswählen.

### Benutzereingabe und Fehlerbehandlung

- Bitte den Benutzer um Eingabe des Betrags in der Ausgangswährung.
- Verwende einen `try-catch`-Block, um sicherzustellen, dass die Eingabe eine gültige Zahl ist.
- Gib eine Fehlermeldung aus, wenn eine ungültige Eingabe erkannt wird, und bitte um erneute Eingabe.

### Umrechnung und Ausgabe

- Verwende `switch-case`, um die ausgewählte Umrechnung zu bestimmen und durchzuführen.
- Zeige das Umrechnungsergebnis an.

### Programmende

- Ermögliche es dem Benutzer, das Programm nach einer Umrechnung zu beenden oder eine neue Umrechnung zu starten.

## Hinweise

- Definiere feste Wechselkurse für jede Währungskombination.
- Nutze `Convert.ToDouble()` für die Umwandlung der Eingabe in eine Zahl und implementiere eine entsprechende Fehlerbehandlung.
