# Übung: Summe der geraden Zahlen bis zu einer eingegebenen Grenze

## Ziel der Übung

Das Ziel dieser Übung ist es, ein Konsolenprogramm in C# zu erstellen, das den Benutzer dazu auffordert, eine positive Ganzzahl einzugeben. Das Programm sollte dann alle geraden Zahlen von 1 bis zu dieser eingegebenen Zahl summieren und das Ergebnis ausgeben.

## Anforderungen

1. **Programmstart**: Beim Start sollte das Programm den Benutzer begrüßen und kurz erklären, was es tut.
  
2. **Eingabeaufforderung**: Das Programm sollte den Benutzer dazu auffordern, eine positive Ganzzahl einzugeben. Wenn die Eingabe nicht positiv ist, sollte die Aufforderung wiederholt werden.
  
3. **Benutzereingabe verarbeiten**: Verwende `Console.ReadLine()` und `Convert.ToInt32()` um die Eingabe des Benutzers zu verarbeiten.

4. **Berechnung**: Verwende eine `for`-Schleife, um alle Zahlen von 1 bis zur eingegebenen Zahl zu durchlaufen. Nutze eine `if`-Verzweigung innerhalb der Schleife, um zu prüfen, ob die aktuelle Zahl gerade ist. Wenn sie gerade ist, sollte sie zur Gesamtsumme hinzugefügt werden.

5. **Ausgabe**: Nachdem die Schleife beendet ist, sollte das Programm die Summe aller geraden Zahlen von 1 bis zur eingegebenen Zahl ausgeben.

## Beispiel

Wenn der Benutzer die Zahl 6 eingibt, sollte das Programm die Summe von 2, 4 und 6 berechnen und 12 ausgeben.

## Optional

* Füge eine Überprüfung hinzu, die sicherstellt, dass die Benutzereingabe tatsächlich eine Zahl ist, bevor `Convert.ToInt32()` aufgerufen wird.

