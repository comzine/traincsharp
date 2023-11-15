# Übung: String in Ganzzahl Umwandeln unter Verwendung der ASCII-Werte

## Ziel

Entwickeln Sie einen Algorithmus in C#, der einen numerischen String in eine Ganzzahl umwandelt, indem Sie die ASCII-Werte der Zeichen berücksichtigen, ohne eingebaute Parsing-Methoden wie `int.Parse()` zu verwenden.

## Beschreibung

Schreiben Sie ein C#-Programm, das einen String einliest und diesen in eine Ganzzahl umwandelt, indem es die ASCII-Werte der einzelnen Zeichen berücksichtigt.

## Anforderungen

- Implementieren Sie das Programm in der `Main`-Funktion.
- Fordern Sie den Benutzer auf, eine Zahl als String einzugeben.
- Entwickeln Sie einen Algorithmus, der den eingegebenen String in eine Ganzzahl umwandelt, indem er die ASCII-Werte der Zeichen nutzt.
- Recherchieren Sie die ASCII-Werte der Zeichen '0' bis '9'. Sie können diese Werte nutzen, um die numerischen Werte der Zeichen zu berechnen.
- Berücksichtigen Sie mögliche Fehlerquellen wie nicht-numerische Zeichen und behandeln Sie diese entsprechend.
- Geben Sie das Ergebnis auf der Konsole aus. Wenn die Umwandlung nicht möglich ist, geben Sie eine entsprechende Fehlermeldung aus.

## Beispiel

```
Bitte geben Sie eine Zahl ein: 12345
Die umgewandelte Ganzzahl ist: 12345

Bitte geben Sie eine Zahl ein: abc123
Fehler: Ungültige Eingabe. Bitte geben Sie nur Zahlen ein.
```

## Hinweise

- Überlegen Sie, wie Sie die Position jedes Zeichens im String nutzen können, um den Gesamtwert der Zahl zu berechnen (z.B. Zehnerpotenzen).
- Achten Sie darauf, dass die Eingabe des Benutzers gültig ist und nur Ziffern enthält.
