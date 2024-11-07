# Übung: Gefängnistüren-Simulation

## Ziel

Erstelle ein Konsolenprogramm in C#, das einen historischen Algorithmus zur Öffnung und Schließung von Gefängnistüren simuliert und die Anzahl der am Ende offenen Türen berechnet.

## Anforderungen

1. **Initialisierung**:

   - Erstelle ein bool-Array mit 100 Elementen
   - True repräsentiert eine offene Tür
   - False repräsentiert eine geschlossene Tür
   - Setze alle Türen auf `false` (geschlossen)

2. **Algorithmus-Implementation**:

   - Implementiere 100 Durchgänge mit folgender Logik:
     - Erster Durchgang: Alle Türen werden geöffnet
     - Zweiter Durchgang: Jede zweite Tür wird geschlossen
     - Ab drittem Durchgang: Bei jeder n-ten Tür wird der Status umgekehrt (offen wird geschlossen, geschlossen wird geöffnet)

3. **Berechnung und Ausgabe**:
   - Zähle die Anzahl der offenen Türen nach dem letzten Durchgang
   - Gebe das Ergebnis auf der Konsole aus

## Technische Spezifikationen

- Programmiersprache: C#
- Datenstruktur: bool-Array mit 100 Elementen
- Ausgabeformat: Konsolenausgabe

## Beispielablauf

1. Alle Türen werden initial auf false (geschlossen) gesetzt
2. Nach dem ersten Durchgang sind alle Türen true (offen)
3. Nach dem zweiten Durchgang ist jede zweite Tür false
4. Dies wird fortgesetzt bis zum hundertsten Durchgang
5. Finale Ausgabe der Anzahl der offenen Türen

## Optional

- Passe das Programm so an, dass die Anzahl der Türen variabel ist und per Konsoleneingabe festgelegt werden kann.
- Gebe aus, welche Türen am Ende offen sind (z.B. "Tür 1, Tür 4, Tür 9, ...")
