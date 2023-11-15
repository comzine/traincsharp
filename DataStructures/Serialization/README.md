# Objektserialisierung in der Informatik und deren Anwendung in C#

## Grundlagen der Objektserialisierung

- **Definition:** Prozess der Umwandlung von Objekten in einen Datenstrom zur Speicherung oder Übertragung.
- **Ziel:** Objekte speichern oder übertragen, um sie später in ursprünglicher Form wiederherstellen zu können.

## Arten der Serialisierung

- **Binäre Serialisierung:**
  - Wandelt Objekte in eine binäre Datenfolge um.
  - Effizient in Bezug auf Datengröße und Geschwindigkeit.
  - Ideal, wenn Daten nur von Computern verarbeitet werden.

- **Protokollbasierte Serialisierung:**
  - Nutzt spezifische Kommunikationsprotokolle (z.B. XML, JSON).
  - Bietet mehr Flexibilität und Interoperabilität.
  - Geeignet für den Datenaustausch zwischen verschiedenen Systemen oder Sprachen.

## Objektserialisierung in C# anhand eines Beispielprogramms (Program.cs)

- **Programmstruktur:**
  - Definition einer serialisierbaren Klasse `MeinObjekt` mit Eigenschaften `Id` und `Name`.
  - Hauptprogramm (`Main`-Methode) führt sowohl binäre als auch JSON-Serialisierung und Deserialisierung durch.

- **Binäre Serialisierung und Deserialisierung:**
  - Verwendet `System.Runtime.Serialization.Formatters.Binary` für die binäre Serialisierung.
  - Die Methode `BinareSerialisierungInDatei` serialisiert das Objekt in eine Datei im binären Format.
  - Die Methode `BinareDeserialisierungAusDatei` liest die binäre Datei und deserialisiert sie in ein `MeinObjekt`-Objekt.

- **JSON-Serialisierung und Deserialisierung:**
  - Nutzt das `System.Text.Json`-Namespace für die JSON-Serialisierung.
  - Die Methode `JsonSerialisierungInDatei` serialisiert das Objekt in JSON und speichert es in einer Datei.
  - Die Methode `JsonDeserialisierungAusDatei` liest die JSON-Daten aus einer Datei und deserialisiert sie zurück in ein `MeinObjekt`-Objekt.
  - Beim Deserialisieren werden Optionen wie `PropertyNamingPolicy` und `WriteIndented` für die Formatierung genutzt.

- **Funktionsweise:**
  - Beide Serialisierungsarten (binär und JSON) werden genutzt, um das `MeinObjekt`-Objekt in Dateien zu speichern und anschließend wieder zu deserialisieren.
  - Demonstrationszwecke zeigen die unterschiedlichen Herangehensweisen und Möglichkeiten der Serialisierung in C#. 
