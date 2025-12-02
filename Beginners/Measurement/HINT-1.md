# 💡 Hint 1: Erste Orientierung

> **Ziel dieses Hints:** Dir helfen zu verstehen, WAS du tun musst - noch nicht WIE.

## Aufgabe in einfachen Worten

Du sollst ein Programm schreiben, das **Messwerte speichert und analysiert** - wie ein digitales Messgerät, das jede Stunde einen Wert aufzeichnet.

## Die drei Hauptteile

### Teil 1: Daten erstellen
Stell dir vor, du hast ein Messgerät, das **jede Stunde** einen Wert misst - **das ganze Jahr lang**.

- 12 Monate × 31 Tage × 24 Stunden = sehr viele Messwerte!
- Diese speicherst du in einem "3D-Array" (wie ein Regal mit Fächern)

### Teil 2: Daten korrigieren
Manchmal war das Messgerät falsch kalibriert. Für einen bestimmten Zeitraum (13. August bis 16. September) musst du alle Werte um 10% erhöhen.

### Teil 3: Daten analysieren
- Zeige Werte für März bis Juni an
- Finde den kleinsten und größten Wert
- Berechne den Durchschnitt

## Denkanstoß

Bevor du codest, überlege:

1. **Wie adressiere ich einen bestimmten Messwert?**
   - Z.B. "Der Wert vom 15. März um 14:00 Uhr"

2. **Wie gehe ich durch alle Werte?**
   - Tipp: Du brauchst drei ineinander geschachtelte Schleifen

3. **Wie finde ich den größten/kleinsten Wert?**
   - Tipp: Merke dir den bisher besten Wert und vergleiche

---

📖 **Grundlagen vergessen?**
- [Arrays in C#](./BASICS-ARRAYS.md)
- [Schleifen in C#](./BASICS-LOOPS.md)

➡️ **Noch mehr Hilfe?** [Hint 2: Technische Details](./HINT-2.md)
