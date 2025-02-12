# Übung: IP-Adress-Rechner

## Ziel

Entwickle ein Konsolenprogramm in C#, das für eine eingegebene IP-Adresse und Netzmaske die Netzwerk- und Broadcast-Adresse berechnet. Das Programm soll die Umrechnung zwischen Dezimal- und Binärzahlen beherrschen und die Netzwerkberechnung nach den Regeln der IPv4-Adressierung durchführen.

## Anforderungen

### 1. Eingabefunktionen

- Implementiere eine Funktion `InputIpAddress()`, die:

  - Eine IP-Adresse im Format "xxx.xxx.xxx.xxx" einliest
  - Die Eingabe an den Punkten trennt
  - Die Teile in ein Integer-Array mit 4 Elementen umwandelt

- Implementiere eine Funktion `InputMask()`, die:
  - Eine Netzmaske als einzelne Zahl (CIDR-Notation) einliest
  - Die Eingabe in einen Integer-Wert umwandelt

### 2. Konvertierungsfunktionen

- Implementiere eine Funktion `DezimalToDual()`, die:

  - Eine Dezimalzahl in ihre 8-stellige Binärdarstellung umwandelt
  - Das Ergebnis als Integer-Array zurückgibt

- Implementiere eine Funktion `DualToDezimal()`, die:
  - Ein Binärzahl-Array in die entsprechende Dezimalzahl umwandelt
  - Das Ergebnis als Integer zurückgibt

### 3. Berechnungsfunktionen

- Implementiere eine Funktion `CalculateNetworkAddress()`, die:

  - Eine IP-Adresse und Netzmaske als Parameter erhält
  - Die Netzwerkadresse nach den IPv4-Regeln berechnet
  - Das Ergebnis als Integer-Array zurückgibt

- Implementiere eine Funktion `CalculateBroadcastAddress()`, die:
  - Eine IP-Adresse und Netzmaske als Parameter erhält
  - Die Broadcast-Adresse nach den IPv4-Regeln berechnet
  - Das Ergebnis als Integer-Array zurückgibt

### 4. Ausgabe

- Gib die berechnete Netzwerk- und Broadcast-Adresse im Format "xxx.xxx.xxx.xxx" aus

## Beispielausführung

```
Enter IP address:
192.168.178.55
Enter mask (for /24 enter 24):
24
Network address: 192.168.178.0
Broadcast address: 192.168.178.255
```

## Hinweise

- Die Netzwerkadresse entsteht durch Nullsetzen aller Bits nach der Netzmaske
- Die Broadcast-Adresse entsteht durch Einsetzen aller Bits nach der Netzmaske
- Nutze die mathematischen Grundlagen der Binär-Dezimal-Umrechnung
- Beachte die korrekte Behandlung der 8-Bit-Grenzen bei der IP-Adresse

## Hilfreiche Methoden

1. **String-Verarbeitung**:

   - `string.Split(char separator)`: Teilt einen String an den angegebenen Trennzeichen
   - `string.Join(string separator, IEnumerable values)`: Verbindet Array-Elemente mit einem Trennzeichen

   ```csharp
   string[] parts = "192.168.178.55".Split('.');  // Ergibt: ["192", "168", "178", "55"]
   string joined = string.Join(".", new int[] {192, 168, 178, 55});  // Ergibt: "192.168.178.55"
   ```

2. **Konvertierung**:

   - `int.Parse(string s)`: Wandelt einen String in eine Ganzzahl um

   ```csharp
   int number = int.Parse("192");  // Ergibt: 192
   ```

3. **Mathematische Operationen**:

   - `Math.Pow(double x, double y)`: Berechnet x hoch y

   ```csharp
   int result = (int)Math.Pow(2, 3);  // Ergibt: 8
   ```

   - Modulo-Operator (`%`): Berechnet den Rest einer Division

   ```csharp
   int rest = 7 % 2;  // Ergibt: 1
   ```

4. **Array-Operationen**:
   - Array-Initialisierung: `int[] array = new int[4];`
   - Array-Zugriff: `array[0] = 192;`
   - Array-Länge: `array.Length`

## Erweiterungsmöglichkeiten

- Implementiere eine Validierung der Eingaben (IP-Adressen im gültigen Bereich 0-255)
- Füge eine Berechnung der ersten und letzten nutzbaren Host-Adresse hinzu
- Ergänze die Ausgabe der Anzahl nutzbarer Host-Adressen im Netzwerk
