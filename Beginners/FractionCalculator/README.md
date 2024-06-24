# Übung: Bruchrechnen mit der Fraction-Klasse

## Ziel
Entwickle eine Fraction-Klasse in C#, mit der man Brüche darstellen und Grundrechenarten wie Addition, Subtraktion, Multiplikation und Division durchführen kann.

## Anforderungen
1. **Fraction-Klasse**: Erstelle eine Klasse namens `Fraction` mit den folgenden Eigenschaften und Methoden:
   - Eigenschaften:
     - `Numerator` (Zähler) vom Typ `int`
     - `Denominator` (Nenner) vom Typ `int`
   - Konstruktor:
     - `Fraction(int numerator, int denominator)`: Initialisiert eine neue Instanz der Fraction-Klasse mit dem angegebenen Zähler und Nenner.
   - Methoden:
     - `Add(Fraction other)`: Addiert den aktuellen Bruch mit einem anderen Bruch und gibt das Ergebnis als neuen Bruch zurück.
     - `Subtract(Fraction other)`: Subtrahiert einen anderen Bruch vom aktuellen Bruch und gibt das Ergebnis als neuen Bruch zurück.
     - `Multiply(Fraction other)`: Multipliziert den aktuellen Bruch mit einem anderen Bruch und gibt das Ergebnis als neuen Bruch zurück.
     - `Divide(Fraction other)`: Dividiert den aktuellen Bruch durch einen anderen Bruch und gibt das Ergebnis als neuen Bruch zurück.
     - `ToString()`: Gibt den Bruch als String in der Form "Zähler/Nenner" zurück.

2. **Bruchoperationen**: Führe die folgenden Bruchoperationen durch in der Main Methode der Program-Klasse aus und gib die Ergebnisse auf der Konsole aus:
   - Erzeuge zwei Brüche (`fraction1` und `fraction2`) mit beliebigen Werten.
   - Addiere `fraction1` und `fraction2` und speichere das Ergebnis in einer Variablen `sum`.
   - Subtrahiere `fraction2` von `fraction1` und speichere das Ergebnis in einer Variablen `difference`.
   - Multipliziere `fraction1` und `fraction2` und speichere das Ergebnis in einer Variablen `product`.
   - Dividiere `fraction1` durch `fraction2` und speichere das Ergebnis in einer Variablen `quotient`.
   - Gib die Ergebnisse der Operationen unter Verwendung der `ToString()`-Methode auf der Konsole aus.

## Beispielausgabe
```
Sum: 41/28
Difference: -1/28
Product: 15/28
Quotient: 21/20
```

## Optional
- Implementiere eine Methode zum Kürzen von Brüchen in der Fraction-Klasse.
- Überlege dir eine Möglichkeit, wie du Sonderfälle wie Division durch Null oder negative Nenner behandeln kannst.