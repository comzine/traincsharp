# Übung: Quersumme Berechnen mit String-Manipulation

## Ziel

Diese Übung soll die Verwendung von Strings und deren Methoden in C# trainieren, insbesondere im Kontext der Berechnung von Quersummen.

## Beschreibung

Schreiben Sie ein C#-Programm, das eine Zahl als String vom Benutzer einliest und die Quersumme dieser Zahl berechnet. Die Quersumme ist die Summe aller Ziffern einer Zahl. Zum Beispiel ist die Quersumme von "12345" gleich 1 + 2 + 3 + 4 + 5 = 15.

## Anforderungen

- Implementieren Sie das Programm in der `Main`-Funktion.
- Fordern Sie den Benutzer auf, eine Zahl als String einzugeben.
- Stellen Sie sicher, dass die Eingabe nur Ziffern enthält.
- Berechnen Sie die Quersumme, indem Sie auf die einzelnen Ziffern des Strings zugreifen.
- Geben Sie das Ergebnis auf der Konsole aus.

## Beispiel

```
Bitte geben Sie eine Zahl ein: 12345
Die Quersumme von 12345 ist: 15
```

## Hinweise

- Verwenden Sie die Methode `string.Length` und eine Schleife, um durch jeden Charakter des Strings zu iterieren.
- Konvertieren Sie jeden Charakter in eine Zahl, um die Quersumme zu berechnen. Dies kann mit `int.Parse(string)` oder `Char.GetNumericValue(char)` erreicht werden.
- Achten Sie darauf, dass die Eingabe des Benutzers gültig ist und nur Ziffern enthält.
