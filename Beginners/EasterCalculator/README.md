# Gaußsche Osterformel

## Ziel der Übung

Entwickle ein Konsolenprogramm in C#, das das Datum des Ostersonntags für ein gegebenes Jahr mithilfe der Gaußschen Osterformel berechnet.

## Anforderungen

### Benutzereingabe

- Fordere den Benutzer auf, ein Jahr einzugeben.

### Berechnung

- Verwende die Gaußsche Osterformel, um das Datum des Ostersonntags zu berechnen. Die Formel besteht aus mehreren Schritten:
  - Bestimme die "Goldene Zahl" `G` für das gegebene Jahr mit `G = (Jahr % 19) + 1`.
  - Berechne die Jahrhundertzahl `C` mit `C = Jahr / 100 + 1`.
  - Ermittle die Korrekturen:
    - `H = (C - (C / 4) - ((8 * C + 13) / 25) + 19 * G - 1) % 30`
    - `I = H - (H / 28) * (1 - (H / 28) * (29 / (H + 1)) * ((21 - G) / 11))`
    - `J = (Jahr + (Jahr / 4) + I + 2 - C + (C / 4)) % 7`
  - Berechne die Länge der Metonischen Mondzyklen `L` mit `L = I - J`.
  - Bestimme den Monat `M` und den Tag `P` des Ostersonntags:
    - `M = 3 + ((L + 40) / 44)`
    - `P = L + 28 - 31 * (M / 4)`

### Ausgabe

- Gib das genaue Datum des Ostersonntags im eingegebenen Jahr aus, bestehend aus Monat (`M`) und Tag (`P`).

### Hinweise

- Beachte, dass die Gaußsche Osterformel nur für Jahre nach dem Gregorianischen Kalenderwechsel im Jahr 1582 gilt.
- Überprüfe, ob das eingegebene Jahr für die Berechnung gültig ist.
- Verwende Ganzzahl-Operationen für die Berechnungen, um Rundungsfehler zu vermeiden.

### Bonus

- Erweitere das Programm so, dass es auch die Daten für Karfreitag und Ostermontag ausgeben kann.

## Tipp

- Die Gaußsche Osterformel ist eine komplexe Berechnung. Es kann hilfreich sein, die Formel in kleinere Berechnungsschritte zu zerlegen und diese einzeln zu implementieren.
- Stelle sicher, dass alle Teilberechnungen korrekt implementiert sind, bevor du versuchst, das endgültige Datum zu berechnen.
