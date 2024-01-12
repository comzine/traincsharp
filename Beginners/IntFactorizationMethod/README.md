# Übung: Faktorisierung einer Zahl mit Methoden

## Ziel
Diese Übung soll die Fähigkeit trainieren, Algorithmen zur Faktorisierung von Zahlen in C# zu entwickeln und zu verstehen, einschließlich der Erstellung und Verwendung eigener Methoden.

## Beschreibung
Schreiben Sie ein C#-Programm, das eine Ganzzahl vom Benutzer einliest und die Faktorisierung dieser Zahl durchführt. Die Faktorisierung ist die Darstellung einer Zahl als Produkt ihrer Faktoren. Implementieren Sie dazu zwei Methoden: `Factorization` zur Berechnung der Faktoren und `PrintFactors` zur Ausgabe der Faktoren.

## Anforderungen
- Implementieren Sie das Programm in der `Main`-Funktion.
- Fordern Sie den Benutzer auf, eine Ganzzahl größer als 0 einzugeben.
- Implementieren Sie eine Methode `Factorization`, die die Faktoren der eingegebenen Zahl berechnet und in einem Array zurückgibt.
- Implementieren Sie eine Methode `PrintFactors`, die die Faktoren aus dem Array in der Form `2 * 3 * 5` für die Eingabe `30` auf der Konsole ausgibt.
- Verwenden Sie diese Methoden in der `Main`-Funktion, um die Faktorisierung durchzuführen und die Faktoren auszugeben.
- Beenden Sie das Programm, wenn der Benutzer eine Zahl kleiner als 0 eingibt.

## Beispiel
```
Enter a number greater than 0 (smaller than 0 means exit): 30
2 * 3 * 5

Enter a number greater than 0 (smaller than 0 means exit): -1
```

## Hinweise
- Die Methode `Factorization` sollte eine Schleife verwenden, um die Faktoren der Zahl zu finden.
- Die Methode `PrintFactors` sollte die Faktoren aus dem Array formatiert ausgeben.
- Überlegen Sie, wie Sie die Faktoren in einem Array speichern und dieses Array zwischen den Methoden übergeben können.

