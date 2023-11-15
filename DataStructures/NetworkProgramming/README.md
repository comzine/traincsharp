# Netzwerkprogrammierung in C# mit Sockets

## Einführung in Sockets

- **Sockets:** Bieten die Grundlage für Netzwerkkommunikation in C#.
- **Kommunikation über TCP/IP- und UDP-Protokolle:** Erlauben den Datenaustausch zwischen Netzwerkanwendungen.

## TCP-Sockets

- **TCP (Transmission Control Protocol):**
  - Zuverlässige, verbindungsorientierte Kommunikation.
  - Geeignet für Anwendungen, bei denen Datenintegrität wichtig ist.

- **UDP-Sockets:**
  - UDP (User Datagram Protocol) für verbindungslose Kommunikation.
  - Optimal für Anwendungen, bei denen Geschwindigkeit über Zuverlässigkeit geht.

## Socket-Programmierung in C#

- **Verwendung von `Socket`, `TcpClient`, `TcpListener`:** Aus dem `System.Net.Sockets`-Namespace.
- **Server- und Client-Anwendungen:** Kommunikation über das Netzwerk.

## Kombinierte Server-Client-Anwendung in C#

- **Programmstruktur:**
  - Ein Programm, das zwischen Server- und Client-Modus wählen kann.
  - Benutzerseitige Auswahl für den Modus beim Programmstart.

- **Server-Teil:**
  - Wartet auf eingehende TCP-Verbindungen.
  - Empfängt Daten von einem verbundenen Client.

- **Client-Teil:**
  - Stellt eine Verbindung zum Server her.
  - Sendet Daten an den Server.

- **Serialisierungsoptionen:**
  - Binäre oder JSON-Serialisierung wählbar.
  - Demonstration der Flexibilität in der Datenübertragung.

## Anwendungsbeispiel

- **Einfaches TCP-basiertes Server-Client-System:**
  - Wahl zwischen Server- und Client-Modus beim Start.
  - Möglichkeit, Daten entweder binär oder als JSON zu senden und zu empfangen.
