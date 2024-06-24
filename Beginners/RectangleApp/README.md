# Übung: Rechteck-Klasse

## Ziel
Entwickle eine Rechteck-Klasse in C#, mit der man Rechtecke erstellen und ihre Eigenschaften berechnen kann.

## Anforderungen
1. **Rectangle-Klasse**: Erstelle eine Klasse namens `Rectangle` mit den folgenden Eigenschaften und Methoden:
   - Attribute:
     - `width` (Breite) vom Typ `double`
     - `height` (Höhe) vom Typ `double`
   - Konstruktor:
     - `Rectangle(double width, double height)`: Initialisiert eine neue Instanz der Rectangle-Klasse mit der angegebenen Breite und Höhe.
   - Methoden:
     - `GetArea()`: Berechnet die Fläche des Rechtecks und gibt das Ergebnis als `double` zurück.
     - `GetPerimeter()`: Berechnet den Umfang des Rechtecks und gibt das Ergebnis als `double` zurück.
     - `IsSquare()`: Überprüft, ob das Rechteck ein Quadrat ist (Breite gleich Höhe) und gibt das Ergebnis als `bool` zurück.

2. **Rechteck-Operationen**: Führe die folgenden Operationen durch:
   - Erstelle zwei Rechtecke (`rectangle1` und `rectangle2`) mit unterschiedlichen Breiten und Höhen.
   - Berechne die Fläche und den Umfang von `rectangle1` und `rectangle2` unter Verwendung der entsprechenden Methoden.
   - Überprüfe, ob `rectangle1` und `rectangle2` Quadrate sind, unter Verwendung der `IsSquare()`-Methode.
   - Gib die Ergebnisse der Berechnungen und Überprüfungen auf der Konsole aus.

## Beispielausgabe
```
Rectangle 1:
Area: 24
Perimeter: 20
Is Square: False

Rectangle 2:
Area: 25
Perimeter: 20
Is Square: True
```

## Optional
- Erweitere die Rectangle-Klasse um eine Methode `Scale(double factor)`, die die Breite und Höhe des Rechtecks mit einem gegebenen Faktor multipliziert.
- Implementiere eine Methode `Contains(double x, double y)`, die überprüft, ob ein Punkt mit den Koordinaten (x, y) innerhalb des Rechtecks liegt.