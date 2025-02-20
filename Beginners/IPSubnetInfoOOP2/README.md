# IP-Rechner: Von prozedural zu OOP - Aufgabenserie

## Teil 2: Binärzahlen als Objekte - BinaryNumber

In Teil 1 haben wir eine Klasse `IPAddress` erstellt. Nun erweitern wir das Projekt um eine Klasse zur Verwaltung von Binärzahlen und integrieren diese in unsere `IPAddress`-Klasse.

### UML-Klassendiagramme

#### Ausgangssituation (Teil 1)

```plaintext
+-----------------------------------+
|             IPAddress             |
+-----------------------------------+
| - octets: int[]                   |
+-----------------------------------+
| + IPAddress(ipString: string)     |
| + ToString(): string              |
| - ValidateOctet(value: int): bool |
+-----------------------------------+
```

#### Zielstruktur (Teil 2)

```plaintext
+-----------------------------------------+
|             BinaryNumber                |
+-----------------------------------------+
| - bits: int[]                           |
+-----------------------------------------+
| + BinaryNumber(binary: string)          |
| + BinaryNumber(decimal: int)            |
| + ToDecimal(): int                      |
| + ToString(): string                    |
| + ToString(length: int): string         |
| - ValidateBinary(binary: string): bool  |
| + GetBit(position: int): int            |
| + GetLength(): int                      |
| + Add(other: BinaryNumber): BinaryNumber|
| + Invert(): void                        |
| + ShiftLeft(positions: int): void       |
| + ShiftRight(positions: int): void      |
+-----------------------------------------+
                 ▲
                 |
                 | verwendet
                 |
+-----------------------------------------+
|             IPAddress                   |
+-----------------------------------------+
| - octets: BinaryNumber[]                |
+-----------------------------------------+
| + IPAddress(ipString: string)           |
| + ToString(): string                    |
| + ToString(format: string): string      |
| - ValidateOctet(value: int): bool       |
+-----------------------------------------+
```

### Lernziele

- Implementierung einer weiteren Klasse
- Arbeiten mit Arrays zur Datenspeicherung
- Konvertierung zwischen Zahlensystemen
- Verwendung von Klassen in anderen Klassen

### Aufgabenschritte

#### 1. Erstellen der BinaryNumber-Klasse

1. Erstelle eine neue Klasse `BinaryNumber`
2. Füge ein privates Feld `bits` vom Typ `int[]` hinzu

#### 2. Basis-Funktionalität

1. Implementiere die `ValidateBinary`-Methode

   ```csharp
   private bool ValidateBinary(string binary)
   {
       // TODO: Prüfe auf null oder leer
       // TODO: Prüfe, ob nur 0 und 1 enthalten sind
   }
   ```

2. Implementiere die `ToString`-Methode

   ```csharp
   public override string ToString()
   {
       // TODO: Konvertiere das Bits-Array in einen String
   }
   ```

3. Implementiere den ersten Konstruktor für Binär-Strings

   ```csharp
   public BinaryNumber(string binary)
   {
       // TODO: Validiere den String (nur 0 und 1)
       // TODO: Erstelle ein Array mit der Länge des Strings
       // TODO: Fülle das Array mit den Bits
   }
   ```

#### 3. Konvertierungsmethoden

1. Implementiere die `ToDecimal`-Methode

   ```csharp
   public int ToDecimal()
   {
       // TODO: Berechne den Dezimalwert der Binärzahl
       // Hinweis: Jede Position ist eine Potenz von 2
   }
   ```

2. Implementiere den zweiten Konstruktor

   ```csharp
   public BinaryNumber(int decimalNumber)
   {
       // TODO: Konvertiere die Dezimalzahl in Binär
       // Hinweis: Verwende wiederholte Division durch 2
   }
   ```

#### 4. Erweiterte Formatierung

1. Implementiere die `ToString(int length)`-Methode

   ```csharp
   public string ToString(int length)
   {
       // TODO: Gib die Binärzahl mit führenden Nullen zurück
       // TODO: Prüfe, ob length ausreichend groß ist
   }
   ```

#### 5. Integration in IPAddress

1. Ändere das Feld `octets` in der IPAddress-Klasse

   ```csharp
   private BinaryNumber[] octets;
   ```

2. Passe den Konstruktor an

   ```csharp
   public IPAddress(string ipString)
   {
       // TODO: Erstelle für jedes Oktett ein BinaryNumber-Objekt
   }
   ```

3. Implementiere die formatierte Ausgabe

   ```csharp
   public string ToString(string format)
   {
       // TODO: Füge "binary" als Ausgabeformat hinzu
   }
   ```

### Testfälle

Teste deine Implementierung mit folgenden Fällen:

1. BinaryNumber-Tests

   ```csharp
   BinaryNumber b1 = new BinaryNumber("1010");  // Sollte funktionieren
   BinaryNumber b2 = new BinaryNumber("12");    // Sollte Exception werfen
   BinaryNumber b3 = new BinaryNumber(10);      // Sollte "1010" erstellen
   Console.WriteLine(b1.ToDecimal());           // Sollte 10 ausgeben
   Console.WriteLine(b1.ToString(8));           // Sollte "00001010" ausgeben
   ```

2. IPAddress-Tests

   ```csharp
   IPAddress ip = new IPAddress("192.168.1.1");
   Console.WriteLine(ip.ToString());            // Normal: 192.168.1.1
   Console.WriteLine(ip.ToString("binary"));    // Binär: 11000000.10101000...
   ```

### Zusatzaufgaben

Wenn du die Grundfunktionalität implementiert hast, kannst du folgende Erweiterungen hinzufügen:

1. Methode zum Addieren zweier BinaryNumber-Objekte

   ```csharp
   public BinaryNumber Add(BinaryNumber other)
   ```

2. Methoden zum Verschieben der Bits

   ```csharp
   public void ShiftLeft(int positions)
   public void ShiftRight(int positions)
   ```

3. Methode zum Invertieren aller Bits

   ```csharp
   public void Invert()
   ```

### Hinweise

- Teste jeden Schritt einzeln
- Nutze die Debug-Funktion von Visual Studio
- Achte auf eine gründliche Fehlerbehandlung
- Kommentiere deinen Code

### Hilfestellung

- Dezimal nach Binär: Wiederholte Division durch 2, Reste ergeben die Binärzahl
- Binär nach Dezimal: Summe der Potenzen von 2 an Stellen mit 1
- Beispiel: 1010 = 1×2³ + 0×2² + 1×2¹ + 0×2⁰ = 8 + 0 + 2 + 0 = 10

### Abgabe

- Vollständiger Quellcode beider Klassen
- Testprogramm mit Beispielausgaben
- Dokumentation der implementierten Zusatzaufgaben
