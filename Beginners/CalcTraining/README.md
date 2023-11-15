# Übung: Zufällige Rechenaufgaben

## Ziel der Übung

Das Ziel dieser Übung ist es, ein Konsolenprogramm in C# zu erstellen, das zufällige Rechenaufgaben generiert und den Benutzer nach dem Ergebnis fragt. Das Programm sollte die Random-Klasse verwenden, um Zahlen und Operatoren für die Rechenaufgaben zufällig auszuwählen.

## Anforderungen

1. **Programmstart**: Beim Start sollte das Programm den Benutzer begrüßen und erläutern, was es macht.
  
2. **Zufallsgenerierung**: Verwende die `Random`-Klasse in C#, um zwei zufällige Ganzzahlen zwischen 1 und 100 sowie einen zufälligen Operator (Addition `+` oder Multiplikation `*`) zu generieren.

3. **Rechenaufgabe stellen**: Zeige dem Benutzer die generierte Rechenaufgabe an und bitte um die Eingabe des Ergebnisses.
    * Beispiel: "Was ist 43 + 57?"

4. **Benutzereingabe**: Lies die Antwort des Benutzers ein und überprüfe, ob sie korrekt ist.

5. **Ergebnisausgabe**: Teile dem Benutzer mit, ob die Antwort korrekt oder falsch war. Bei einer falschen Antwort sollte das richtige Ergebnis angezeigt werden.

6. **Wiederholung**: Nach jeder Aufgabe sollte der Benutzer gefragt werden, ob er eine weitere Rechenaufgabe lösen möchte. Das Programm sollte erst beendet werden, wenn der Benutzer dies ablehnt.

## Optional

* Füge weitere Operatoren wie Subtraktion `-` und Division `/` hinzu, aber achte darauf, dass keine Division durch Null auftritt.
* Zähle, wie viele Antworten der Benutzer richtig oder falsch hatte und zeige diese Statistik an, wenn das Programm beendet wird.
