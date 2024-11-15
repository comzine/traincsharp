# Übung: Implementierung einer String-zu-Integer Konvertierung

## Ziel

Entwickle eine Methode in C#, die einen String, der eine Zahl repräsentiert, in einen Integer-Wert konvertiert, ohne die eingebaute Parse- oder Convert-Funktionen zu verwenden.

## Anforderungen

1. **StringToInt Methode**:

   - Implementiere eine Methode, die einen String-Parameter entgegennimmt
   - Die Methode soll einen Integer-Wert zurückgeben
   - Verwende keine eingebauten Konvertierungsfunktionen wie `int.Parse()` oder `Convert.ToInt32()`

2. **Hilfsmethode Power**:

   - Implementiere eine Methode zur Berechnung von Potenzen
   - Die Methode soll zwei Parameter entgegennehmen: Basis und Exponent
   - Berechne das Ergebnis ohne Verwendung von `Math.Pow()`

3. **Konvertierungslogik**:
   - Wandle jeden einzelnen Character in seinen numerischen Wert um
   - Berücksichtige die Position der Ziffer im String (Einerstelle, Zehnerstelle, etc.)
   - Berechne den Gesamtwert durch Addition der einzelnen Stellenwerte

## Beispielaufruf

```csharp
int result = StringToInt("123");  // Soll 123 zurückgeben
Console.WriteLine(result);
```

## Hinweise

- ASCII-Wert für die Ziffer '0' ist 48
- Die Verarbeitung erfolgt von rechts nach links
- Jede Position entspricht einer 10er-Potenz (1er, 10er, 100er, etc.)

## Optional

- Erweitere die Methode um eine Fehlerbehandlung für ungültige Eingaben
- Implementiere die Verarbeitung von negativen Zahlen
- Füge eine Überprüfung auf Integer-Überläufe hinzu
