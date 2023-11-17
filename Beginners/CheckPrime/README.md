# Übung: Überprüfen, ob eine Zahl eine Primzahl ist

## Ziel

Diese Übung soll die Fähigkeit trainieren, Algorithmen zur Überprüfung von Primzahlen in C# zu entwickeln und zu verstehen.

## Beschreibung

Schreiben Sie ein C#-Programm, das eine Ganzzahl vom Benutzer einliest und überprüft, ob diese Zahl eine Primzahl ist. Eine Primzahl ist eine natürliche Zahl größer als 1, die keine positiven Teiler hat außer 1 und sich selbst.

## Anforderungen

- Implementieren Sie das Programm in der `Main`-Funktion.
- Fordern Sie den Benutzer auf, eine Ganzzahl einzugeben.
- Stellen Sie sicher, dass die Eingabe eine gültige Ganzzahl ist.
- Überprüfen Sie, ob die eingegebene Zahl eine Primzahl ist.
- Geben Sie das Ergebnis auf der Konsole aus: "The number is prime." oder "The number is not prime.", je nachdem, ob die Zahl eine Primzahl ist oder nicht.

## Beispiel

```
Please enter a number: 11
The number is prime.

Please enter a number: 10
The number is not prime.
```


## Hinweise

- Verwenden Sie `try-catch` und `Convert.ToInt32` zur Validierung der Eingabe und zur Konvertierung des Strings in eine Zahl.
- Nutzen Sie eine Schleife und bedingte Anweisungen, um zu überprüfen, ob die Zahl eine Primzahl ist.
- Beachten Sie, dass Zahlen kleiner als 2 nicht als Primzahlen gelten.
