# TCP-Netzwerkkommunikation mit Asynchronen Methoden in C#

Dieses C#-Programm ermöglicht die asynchrone TCP-Netzwerkkommunikation zwischen einem Server und einem Client. Es beinhaltet die Übertragung eines serialisierbaren Objekts (`MeinObjekt`) entweder im binären Format oder als JSON.

## Klassenbeschreibung

### `MeinObjekt` Klasse
- Eine Klasse, die für Netzwerkkommunikationszwecke serialisiert werden kann.
- Enthält Eigenschaften `Id` und `Name`.
- Markiert mit `[Serializable]` für die Serialisierung.
- `ToString`-Methode für eine benutzerfreundliche Ausgabe.

## Hauptprogramm `TcpProgram`

### `Main` Methode
- Startpunkt des Programms, fragt den Benutzer nach dem gewünschten Modus (Server oder Client).
- Leitet je nach Benutzerauswahl zum Server- oder Client-Modus weiter.
- Implementiert eine unendliche Schleife zur Demonstration eines fortlaufenden Betriebs.

## Server-Funktionalitäten

### `StarteServerAsync` Methode
- Initialisiert einen TCP-Server, der auf eingehende Verbindungen wartet.
- Verwendet eine Endlosschleife, um kontinuierlich auf neue Verbindungen zu hören.

### `HandleClientAsync` Methode
- Verarbeitet die Daten, die von einem verbundenen Client empfangen werden.
- Unterstützt sowohl binäre als auch JSON-basierte Datenübertragung.

## Client-Funktionalitäten

### `StarteClientAsync` Methode
- Stellt eine asynchrone Verbindung zum Server her.
- Sendet ein Objekt vom Typ `MeinObjekt` entweder in binärer Form oder als JSON.

## Asynchrone Kommunikation
- Nutzt `async` und `await` für nicht blockierende Netzwerkoperationen.
- Erlaubt effiziente Verarbeitung paralleler Netzwerkanfragen.

## Anmerkungen zum Programm
- Ein einfaches Beispiel zur Demonstration der Netzwerkprogrammierung in C#.
- Zeigt den Umgang mit synchronen und asynchronen Kommunikationsmustern.
- Bietet Flexibilität in der Datenübertragung durch die Wahl zwischen binärer und JSON-Serialisierung.
