# Übung: Messwerterfassung mit dreidimensionalem Array

## Ziel

Entwickle ein C#-Konsolenprogramm zur Verwaltung von stündlichen Messwerten über ein Jahr. Die Daten werden in einem dreidimensionalen Array gespeichert und ausgewertet.

## Anforderungen

### 1. Array-Erstellung und Befüllung

- Erstelle ein dreidimensionales Array vom Typ `float[,,]` mit:
  - 12 Monaten (erste Dimension)
  - 31 Tagen (zweite Dimension)
  - 24 Stunden (dritte Dimension)
- Fülle das Array mit Zufallswerten zwischen 0 und 15
- Verwende dafür verschachtelte for-Schleifen und die Random-Klasse

### 2. Messwert-Korrektur

- Korrigiere die Messwerte für einen bestimmten Zeitraum:
  - Zeitraum: 13. August bis 16. September
  - Multipliziere alle Werte in diesem Zeitraum mit 1,1
- Verwende verschachtelte for-Schleifen für die Korrektur
- Beachte: August = Index 7, September = Index 8

### 3. Datenausgabe und Analyse

1. **Ausgabe eines Zeitraums**

   - Gib alle Werte von März (Index 2) bis Juni (Index 5) aus
   - Nutze drei verschachtelte for-Schleifen
   - Zeige für jeden Wert: Monat, Tag, Stunde und Messwert

2. **Finden von Extremwerten**

   - Bestimme den kleinsten und größten Wert im Zeitraum März bis Juni
   - Speichere die Positionen in separaten Variablen
   - Gib die gefundenen Extremwerte mit ihren Positionen aus

3. **Durchschnittsberechnung**
   - Berechne den Durchschnitt aller Messwerte
   - Addiere alle Werte in einer Summen-Variable
   - Teile durch die Gesamtanzahl der Messwerte

## Programmablauf

1. Array erstellen und mit Zufallswerten füllen
2. Bestimmte Messwerte korrigieren
3. Werte für den Zeitraum März bis Juni ausgeben
4. Extremwerte finden und ausgeben
5. Durchschnitt berechnen und ausgeben

## Beispielausgabe

```
3D array created
Month: 3, Day: 1, Hour: 0, Value: 7.523
...
Smallest value: 0.234 at Month: 4, Day: 15, Hour: 8
Largest value: 14.876 at Month: 3, Day: 22, Hour: 14
Average value: 7.5
```

## Hinweise

- Monate beginnen bei Index 0 (Januar = 0, Dezember = 11)
- Tage beginnen bei Index 0 (1. Tag = 0, 31. Tag = 30)
- Stunden beginnen bei Index 0 (0:00 Uhr = 0, 23:00 Uhr = 23)
- Bei der Ausgabe muss zu den Monats- und Tagesindizes 1 addiert werden
- Verwende `GetLength()`-Methode für die Array-Dimensionen in den Schleifen

## Hilfestellungen

Kommst du nicht weiter? Nutze die Hints schrittweise – versuche erst den nächsten Hint, bevor du weiterspringst:

1. [💡 Hint 1: Erste Orientierung](./HINT-1.md) – Was muss ich tun?
2. [💡 Hint 2: Technische Details](./HINT-2.md) – Wie funktioniert das?
3. [💡 Hint 3: Code-Beispiele](./HINT-3.md) – Zeig mir ähnlichen Code
4. [💡 Hint 4: Lösungsansatz](./HINT-4.md) – Fast die Lösung ⚠️

## Grundlagen wiederholen

Unsicher bei den Basics? Hier nachlesen:

- [📚 Arrays in C#](./BASICS-ARRAYS.md) – 1D, 2D, 3D Arrays erklärt
- [📚 Schleifen in C#](./BASICS-LOOPS.md) – for-Schleifen und Verschachtelung

## Zusatzaufgaben

- Erweitere das Programm um die Ausgabe der Durchschnittswerte pro Tag
- Füge eine Benutzerabfrage hinzu, welcher Monat analysiert werden soll
- Ergänze eine Prüfung, ob Messwerte über einem Grenzwert liegen
