# Notenübersetzer

## Ziel der Übung

Entwickle ein Konsolenprogramm in C#, das eine eingegebene Schulnote in Textform ausgibt.

## Anforderungen

### Benutzereingabe

- Fordere den Benutzer auf, eine Schulnote als Zahl einzugeben.

### Umwandlung und Ausgabe

- Wandele die eingegebene Zahl in die entsprechende textuelle Bewertung um:
  - `1` für "Sehr gut"
  - `2` für "Gut"
  - `3` für "Befriedigend"
  - `4` für "Ausreichend"
  - `5` für "Mangelhaft"
  - `6` für "Ungenügend"
- Gib die Note und die entsprechende textuelle Bewertung auf dem Bildschirm aus.

### Fehlerbehandlung

- Stelle sicher, dass die Eingabe eine gültige Zahl zwischen 1 und 6 ist und gib eine Fehlermeldung aus, wenn die Eingabe ungültig ist.

## Hinweise

- Verwende `Convert.ToInt32()` oder ähnliche Methoden, um die Benutzereingabe in eine ganze Zahl umzuwandeln.
- Implementiere eine Fehlerbehandlung für den Fall, dass die Eingabe keine gültige Zahl ist.
- Das Programm sollte die Ausgabe klar und verständlich darstellen.

## Beispiel

```
Enter a grade: 2
Grade: 2 (Gut)
```