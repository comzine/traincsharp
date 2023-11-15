# Black Friday Datum Rechner

## Ziel der Übung

Entwickle ein Konsolenprogramm in C#, das das Datum des Black Friday für ein vom Benutzer eingegebenes Jahr berechnet.

## Anforderungen

### Benutzereingabe

- Fordere den Benutzer auf, ein Jahr einzugeben.

### Berechnung

- Berechne das Datum des Black Friday für das eingegebene Jahr.
  - Black Friday ist der Tag nach dem vierten Donnerstag im November.
  - Verwende Zeller's Kongruenz, um den Wochentag des 1. November des gegebenen Jahres zu bestimmen:
    - `h = (q + 13 * (m + 1) / 5 + K + K / 4 + J / 4 - 2 * J) % 7`
    - `q` ist der Tag des Monats (hier immer 1)
    - `m` ist der Monat (hier 11 für November)
    - `J` ist das Jahrhundert (Jahr / 100)
    - `K` ist das Jahr des Jahrhunderts (Jahr % 100)
  - Berechne das Datum des vierten Donnerstags im November basierend auf diesem Wochentag.

### Ausgabe

- Zeige das Datum des Black Fridays im Format `Black Friday im Jahr [Jahr] ist am: [Datum]`.

### Programmlogik

- Verzichte auf die Verwendung der `DateTime`-Klasse.
- Implementiere alle Berechnungen und Logik direkt innerhalb der `Main`-Methode.

## Hinweise

- Achte darauf, dass das Jahr korrekt vom Benutzer eingegeben wird. Verwende `Convert.ToInt32()` zur Umwandlung der Benutzereingabe in eine Zahl.
- Führe eine entsprechende Fehlerbehandlung durch, falls die Eingabe ungültig ist.
- Kommentiere deinen Code, um die Lesbarkeit und Wartbarkeit zu verbessern.
