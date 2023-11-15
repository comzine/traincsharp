# Dateityp-Erkennungsprogramm

## Ziel der Übung

Entwickle ein Konsolenprogramm in C#, das eine Dateierweiterung (wie .jpg, .doc) liest und den entsprechenden Dateityp (wie Bild, Text) identifiziert.

## Anforderungen

### Benutzereingabe

- Fordere den Benutzer auf, eine Dateierweiterung einzugeben.

### Verarbeitung und Ausgabe

- Verwende eine `switch`-Anweisung, um den Dateityp basierend auf der eingegebenen Erweiterung zu ermitteln:
  - Bildtypen: `jpg`, `gif`, `png`
  - Texttypen: `doc`, `txt`, `rtf`
  - Tabellentypen: `xls`, `csv`
- Gib den erkannten Dateityp auf dem Bildschirm aus.
- Zeige "Unbekannt" an, wenn die Erweiterung nicht einer der definierten Kategorien entspricht.

### Schleife

- Nutze eine Schleife, um das Programm so lange auszuführen, bis der Benutzer eine bestimmte Taste drückt, um das Programm zu beenden.
- Nach jeder Eingabe und Ausgabe sollte das Programm den Benutzer erneut zur Eingabe einer Dateierweiterung auffordern.

## Hinweise

- Verwende `System.Console.ReadLine()` für die Benutzereingabe und `System.Console.WriteLine()` für die Ausgabe.
- Beende das Programm sauber mit einer Abschiedsnachricht, wenn der Benutzer dies wünscht.

## Erweiterung

- Stelle sicher, dass das Programm robust gegenüber falschen oder unerwarteten Eingaben ist.
