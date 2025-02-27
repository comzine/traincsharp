# Übung: Lotto-Simulator

## Ziel

Entwickle ein Konsolenprogramm in C#, das ein Lottospiel (6 aus 49) simuliert. Der Benutzer soll seine Glückszahlen eingeben und mehrere Ziehungen simulieren können. Bei einer Falscheingabe soll der Benutzer erneut aufgefordert werden, eine gültige Eingabe zu machen. Nach jeder Ziehung soll die Anzahl der richtigen Zahlen und der Gewinn angezeigt werden. Am Ende des Spiels soll der Gesamtgewinn oder -verlust angezeigt werden.

## Anforderungen

### 1. Spielereingabe

- Implementiere eine Benutzereingabe für 6 verschiedene Zahlen zwischen 1 und 49
- Stelle sicher, dass nur gültige Zahlen akzeptiert werden
- Frage den Benutzer, wie viele Runden simuliert werden sollen

### 2. Kostenberechnung

- Jeder Spielschein kostet 1,50€
- Berechne und zeige die Gesamtkosten für alle Runden an
- Führe eine Gewinn-/Verlustrechnung durch

### 3. Simulation

- Simuliere für jede Runde eine neue Ziehung von 6 Zahlen
- Vergleiche die gezogenen Zahlen mit den Spielerzahlen
- Zeige für jede Runde die Anzahl der richtigen Zahlen an

### 4. Gewinnberechnung

Implementiere folgende Gewinnstaffel:

- 2 Richtige: 5€
- 3 Richtige: 20€
- 4 Richtige: 100€
- 5 Richtige: 1.000€
- 6 Richtige: 1.000.000€

### 5. Ergebnisanzeige

- Zeige nach jeder Runde die Anzahl der richtigen Zahlen und den Gewinn an
- Präsentiere am Ende den Gesamtgewinn oder -verlust

## Erforderliche Methoden

1. `int InputNumberBetween(int min, int max)`

   - Validiert Benutzereingaben
   - Stellt sicher, dass die Eingabe im erlaubten Bereich liegt

2. `int[] DrawNumbers()`

   - Generiert 6 zufällige Zahlen zwischen 1 und 49
   - Gibt ein Array mit den gezogenen Zahlen zurück

3. `int CountCorrectNumbers(int[] numbers, int[] drawnNumbers)`

   - Vergleicht die Spielerzahlen mit den gezogenen Zahlen
   - Zählt die Anzahl der Übereinstimmungen

4. `int GetWonAmount(int correctNumbers)`
   - Ermittelt den Gewinnbetrag basierend auf der Anzahl richtiger Zahlen

## Optionale Erweiterungen

- Implementiere eine BubbleSort Methode und gebe die Benutzer- und gezogenen Kugeln sortiert aus.
- Implementiere eine Prüfung auf doppelte Zahlen bei der Spielereingabe
- Füge eine Statistik hinzu, die die Häufigkeit der verschiedenen Gewinnstufen anzeigt
- Erweitere das Spiel um zusätzliche Lotterievarianten (z.B. 5 aus 50)
- Implementiere eine grafische Darstellung der Gewinnentwicklung

## Hinweise

- Verwende `Random` für die Generierung der Zufallszahlen
- Achte auf eine benutzerfreundliche Eingabevalidierung
