# Übung: Tilgungsplan-Rechner für Annuitätendarlehen

## Ziel

Entwickle ein Konsolenprogramm in C#, das einen detaillierten Tilgungsplan für ein Annuitätendarlehen erstellt. Der Plan soll monatliche Zahlungen, Zinsen, Tilgung und den verbleibenden Kreditbetrag anzeigen.

## Anforderungen

### 1. Eingabe der Kreditdaten

- Implementiere die Eingabe folgender Werte:
  - Kreditbetrag in Euro
  - Zinssatz in Prozent
  - Anfänglicher Tilgungssatz in Prozent

### 2. Berechnung der monatlichen Rate

- Berechne die monatliche Rate (Annuität) aus:
  - Monatliche Zinsen (Kreditbetrag × Zinssatz / 12)
  - Monatliche Tilgung (Kreditbetrag × Tilgungssatz / 12)

### 3. Tilgungsplan

Erstelle eine tabellarische Ausgabe mit folgenden Spalten:

- Monat (als Name, z.B. "Januar")
- Zinsen
- Tilgung
- Restschuld
- Bereits bezahlter Gesamtbetrag

### 4. Strukturierung der Ausgabe

- Gruppiere die Ausgabe nach Jahren
- Formatiere alle Geldbeträge mit zwei Nachkommastellen
- Verwende Tabulatoren für eine übersichtliche Darstellung

### 5. Hilfsfunktionen

Implementiere folgende Methoden:

- `BerechneZinsen`: Berechnet die monatlichen Zinsen
- `BerechneTilgung`: Berechnet den Tilgungsanteil
- `BerechneRestschuld`: Aktualisiert die Restschuld
- `GetMonat`: Wandelt die Monatsnummer in den Monatsnamen um

## Technische Details

- Verwende `long` für Geldbeträge (in Eurocent)
- Verwende `double` für Prozentsätze in Dezimalform
- Nutze geeignete Formatierungen für die Ausgabe (`{value:F2}`)

## Beispielausgabe

```
Monat           Zinsen   Tilgung  Restschuld   Bereits bezahlt
Jahr 1
Januar          166,67    333,33   99.666,67         500,00
Februar         165,28    334,72   99.332,95       1.000,00
...
```

## Hinweise

- Achte auf die korrekte Umrechnung zwischen Euro und Cent
- Berücksichtige Rundungsfehler bei der Verwendung von Gleitkommazahlen
- Die Berechnung läuft so lange, bis der Kredit vollständig getilgt ist

## Erweiterungsmöglichkeiten

- Implementiere eine Überprüfung der Eingabewerte auf Plausibilität
- Füge eine Berechnung der Gesamtzinsen hinzu
- Ermögliche die Ausgabe des Tilgungsplans in eine Datei
- Ergänze eine Funktion zur Berechnung der Restlaufzeit
