# IP-Rechner: Von prozedural zu OOP - Aufgabenserie

## Teil 1: Erste Klasse - IPAddress

### Lernziele

- Verstehen des Unterschieds zwischen prozeduralem und objektorientiertem Code
- Implementierung einer ersten eigenen Klasse
- Anwendung von Datenkapselung durch private/public Konzepte
- Verwendung von Konstruktoren zur Objektinitialisierung
- Fehlerbehandlung in Klassen

### Theoretische Grundlagen

#### Klassen und Objekte

- Eine Klasse ist wie ein Bauplan oder eine Vorlage
- Objekte sind konkrete Instanzen einer Klasse
- Beispiel: Die Klasse `IPAddress` ist der Bauplan, `new IPAddress("192.168.1.1")` erstellt ein konkretes Objekt

#### Eigenschaften von Klassen

1. **Felder (Fields)**

   - Speichern die Daten des Objekts
   - Meist private, um direkte Zugriffe von außen zu verhindern
   - Beispiel: `private int[] octets;`

2. **Konstruktoren**

   - Spezielle Methoden zur Objektinitialisierung
   - Werden beim Erstellen eines Objekts aufgerufen
   - Können Parameter entgegennehmen
   - Beispiel: `public IPAddress(string ipString)`

3. **Methoden**
   - Definieren das Verhalten des Objekts
   - Können public oder private sein
   - Beispiel: `public override string ToString()`

### Erstellen einer neuen Klasse in Visual Studio

1. **Neue Klasse anlegen**

   - Rechtsklick auf das Projekt im Solution Explorer
   - Wähle "Add" → "New Item" (oder Tastenkombination Strg+Shift+A)
   - Wähle "Class" aus der Liste
   - Gib den Namen "IPAddress.cs" ein
   - Klicke auf "Add"

2. **Alternativ über Tastenkombination**

   - Strg+Shift+A drücken
   - "class" eintippen
   - "Class" auswählen
   - Namen "IPAddress.cs" eingeben

3. **Best Practices**
   - Eine Klasse pro Datei
   - Dateiname entspricht dem Klassennamen
   - Gleiche Namespace-Struktur wie das Hauptprogramm verwenden

### Aufgabe

Erstelle eine Klasse `IPAddress`, die eine IPv4-Adresse repräsentiert. Die Klasse soll die bisherige prozedurale Implementierung in eine objektorientierte Form überführen.

```plaintext
+-----------------------------------+
|             IPAddress             |
+-----------------------------------+
| - octets: int[]                   |
+-----------------------------------+
| + IPAddress(ipString: string)     |
| + ToString(): string              |
| + ToString(format: string): string|
| - ValidateOctet(value: int): bool |
| + IsPrivateNetwork(): bool        |
| + GetNetworkClass(): string       |
+-----------------------------------+
```

#### Klassenstruktur

```csharp
public class IPAddress
{
    // Feld für die IP-Adresse
    private int[] octets;

    // Konstruktor
    public IPAddress(string ipString)
    {
        octets = new int[4];
        // TODO: Implementiere die Validierung und Umwandlung der IP-Adresse
    }

    // Überschreiben der ToString()-Methode
    public override string ToString()
    {
        return string.Join(".", octets);
    }

    // Optional: Weitere hilfreiche Methoden
    private bool ValidateOctet(int value)
    {
        return value >= 0 && value <= 255;
    }
}
```

#### Anforderungen

1. **Konstruktor**
   - Nimmt einen String im Format "xxx.xxx.xxx.xxx" entgegen
   - Validiert die Eingabe auf korrektes Format
   - Prüft, ob alle Zahlen im Bereich 0-255 liegen
   - Wirft bei ungültiger Eingabe eine Exception
2. **Validierung**

   - Überprüfung auf null oder leere Strings
   - Prüfung auf genau 4 Oktette
   - Sicherstellung, dass nur Zahlen und Punkte enthalten sind
   - Validierung des Wertebereichs (0-255)

3. **Methoden**
   - `ToString()`: Gibt die IP-Adresse im Format "xxx.xxx.xxx.xxx" zurück
   - Optional: Weitere sinnvolle Methoden implementieren

### Beispielimplementierung Main-Programm

```csharp
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Bitte geben Sie eine IP-Adresse ein (Format: xxx.xxx.xxx.xxx):");
            string input = Console.ReadLine();

            IPAddress ip = new IPAddress(input);
            // ToString() wird hier automatisch aufgerufen
            Console.WriteLine($"Die eingegebene IP-Adresse lautet: {ip}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Fehler: {ex.Message}");
        }
    }
}
```

### Testfälle

Teste deine Implementierung mit folgenden Eingaben:

1. Gültige IP-Adressen:

   - "192.168.1.1"
   - "10.0.0.1"
   - "172.16.254.1"

2. Ungültige IP-Adressen:
   - "256.1.2.3" (Zahl > 255)
   - "1.2.3" (zu wenige Oktette)
   - "1.2.3.4.5" (zu viele Oktette)
   - "abc.def.ghi.jkl" (keine Zahlen)

### Zusatzaufgaben

1. Implementiere eine Methode `IsPrivateNetwork()`, die prüft, ob die IP-Adresse in einem privaten Netzwerk liegt (10.0.0.0/8, 172.16.0.0/12, 192.168.0.0/16)

2. Füge eine Methode `GetOctet(int index)` hinzu, die den Wert eines bestimmten Oktetts zurückgibt

3. Implementiere eine erweiterte `ToString()`-Methode mit folgendem Format:

```csharp
public string ToString(string format)
{
    switch (format?.ToLower())
    {
        case "binary":
            return string.Join(".", octets.Select(o => Convert.ToString(o, 2).PadLeft(8, '0')));
        case "hex":
            return string.Join(".", octets.Select(o => o.ToString("X2")));
        default:
            return string.Join(".", octets);
    }
}
```

### Hinweise zur Implementierung

1. Nutze `string.Split('.')` zur Aufteilung der IP-Adresse
2. Verwende `int.TryParse()` für die sichere Konvertierung der Strings in Zahlen
3. Implementiere die Validierung schrittweise und teste jeden Schritt
4. Nutze aussagekräftige Exception-Meldungen für Fehler

### Tipps für Visual Studio

1. **Code Snippets**

   - Tippe "ctor" + Tab für einen Konstruktor
   - Tippe "prop" + Tab für eine Property
   - Tippe "override" + Leertaste für eine Liste überschreibbarer Methoden

2. **IntelliSense**

   - Nutze Strg+Leertaste für Vorschläge
   - Nutze Strg+Punkt für Quick Actions und Refactorings

3. **Debugging**
   - Setze Breakpoints mit F9
   - Starte das Debugging mit F5
   - Nutze F10 zum Einzelschritt (Step Over)
   - Nutze F11 zum Einzelschritt in Methoden (Step Into)

### Abgabe

- Vollständiger Quellcode der `IPAddress`-Klasse
- Main-Programm mit Beispielverwendung
- Dokumentation der implementierten Zusatzaufgaben (falls bearbeitet)
- Testprotokoll mit mindestens 5 verschiedenen Testfällen
