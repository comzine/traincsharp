# Übung: Temperaturumrechner mit Methodenimplementierung

## Ziel

Entwickle ein Konsolenprogramm in C#, das Temperaturen zwischen Celsius und Fahrenheit umrechnen kann. Die Umrechnungen sollen in separaten Methoden implementiert werden, um die Wiederverwendbarkeit und Übersichtlichkeit des Codes zu gewährleisten.

## Anforderungen

1. **Methodenimplementierung**:

   - Erstelle eine Methode `CelsiusToFahrenheit`, die einen Celsius-Wert als Parameter erhält und den entsprechenden Fahrenheit-Wert zurückgibt
   - Erstelle eine Methode `FahrenheitToCelsius`, die einen Fahrenheit-Wert als Parameter erhält und den entsprechenden Celsius-Wert zurückgibt

2. **Hauptprogramm**:

   - Implementiere ein Hauptprogramm, das beide Umrechnungsmethoden demonstriert
   - Verwende geeignete Beispielwerte für die Demonstration
   - Gib die Ergebnisse formatiert auf der Konsole aus

3. **Formatierung**:
   - Verwende String-Interpolation für die Ausgabe
   - Stelle sicher, dass die Temperatureinheiten (°C und °F) in der Ausgabe erscheinen

## Mathematische Formeln

- Celsius zu Fahrenheit: `°F = (°C × 9/5) + 32`
- Fahrenheit zu Celsius: `°C = (°F - 32) × 5/9`

## Optional

- Erweitere das Programm um eine Benutzereingabe, sodass der Benutzer eigene Temperaturwerte eingeben kann
- Füge eine Auswahlmöglichkeit hinzu, ob von Celsius nach Fahrenheit oder umgekehrt umgerechnet werden soll
- Runde die Ergebnisse auf zwei Nachkommastellen
- Implementiere eine Fehlerbehandlung für ungültige Eingaben

## Beispielausgabe

```
20°C entspricht 68°F
68°F entspricht 20°C
```

## Hinweise

- Achte auf die korrekte Verwendung des Datentyps `double` für die Temperaturwerte
- Beachte die Operatorpräzedenz bei den mathematischen Berechnungen
- Teste deine Implementierung mit verschiedenen Werten, um die Korrektheit zu überprüfen
