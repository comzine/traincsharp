# Übung: IP-Adress-Rechner mit Netzwerk-Analyse

## Ziel

Entwickle ein Konsolenprogramm in C#, das IP-Adressen und Netzmasken verarbeitet, um wichtige Netzwerkinformationen zu berechnen und zu analysieren.

## Theoretische Grundlagen

### IP-Adressen und Netzmasken

Eine IPv4-Adresse besteht aus 4 Oktetten (8-Bit-Zahlen), die durch Punkte getrennt sind. Die Netzmaske in CIDR-Notation gibt an, wie viele Bits von links für das Netzwerk reserviert sind.

### Berechnung der Netzwerkadresse

Die Berechnung der Netzwerkadresse erfolgt in mehreren Schritten:

1. **Bestimmung des betroffenen Oktetts**:

   - Bei einer Netzmaske /16 sind die ersten zwei Oktette komplett Netzwerk
   - Die Formel `mask / 8` gibt das betroffene Oktett an
   - Beispiel: /20 → 20/8 = 2 (drittes Oktett betroffen)

2. **Bestimmung der Bitposition**:

   - Die Formel `mask % 8` gibt die Position im betroffenen Oktett an
   - Beispiel: /20 → 20%8 = 4 (ab dem 4. Bit im dritten Oktett)

3. **Nullsetzen der Host-Bits**:
   - Alle Bits ab der berechneten Position werden auf 0 gesetzt
   - Alle nachfolgenden Oktette werden komplett auf 0 gesetzt

### Beispiel

IP-Adresse: 192.168.177.134/20

```
Position = 20/8 = 2 (drittes Oktett)
Bitposition = 20%8 = 4

177 in Binär: 10110001
Nach Nullsetzen: 10110000 = 176

Ergebnis: 192.168.176.0
```

## Anforderungen

### 1. String-Verarbeitung

- Implementiere die Zerlegung der IP-Adresse mit `Split('.')`
- Verwende `int.Parse()` zur Konvertierung der Teile in Zahlen
- Implementiere Fehlerbehandlung für ungültige Eingaben

### 2. Binäroperationen

Implementiere zwei wichtige Konvertierungsfunktionen:

#### Dezimal zu Binär

```csharp
// Konvertiert eine Dezimalzahl (0-255) in ein 8-Bit Array
static int[] DezimalToDual(int dez)
```

#### Binär zu Dezimal

```csharp
// Konvertiert ein 8-Bit Array zurück in eine Dezimalzahl
static int DualToDezimal(int[] dual)
```

### 3. Netzwerkberechnungen

#### Netzwerkadresse

```csharp
static int[] CalculateNetworkAddress(int[] ipAddress, int mask)
```

- Berechne das betroffene Oktett: `mask / 8`
- Berechne die Bitposition: `mask % 8`
- Setze alle Bits ab dieser Position auf 0
- Setze alle nachfolgenden Oktette auf 0

#### Broadcast-Adresse

```csharp
static int[] CalculateBroadcastAddress(int[] ipAddress, int mask)
```

- Ähnlich wie Netzwerkadresse, aber setze alle Host-Bits auf 1
- Setze alle nachfolgenden Oktette auf 255

## Implementierungsdetails

### Eingabevalidierung

```csharp
// Beispiel für IP-Adress-Validierung
string[] eingabeTeile = eingabe.Split('.');
if (eingabeTeile.Length != 4)
{
    // Fehlerbehandlung
}
```

### Bitoperationen

Für die Umwandlung in Binär:

```csharp
while (dez > 0)
{
    int rest = dez % 2;  // Rest ist das aktuelle Bit
    dez = dez / 2;       // Teile durch 2 für nächstes Bit
}
```

## Hinweise

- Teste dein Programm mit verschiedenen Netzmasken (z.B. /16, /24, /20)
- Beachte Sonderfälle wie /8 oder /30
- Verwende Arrays für die IP-Adressen: `int[] ipAddress = new int[4]`
- Implementiere robuste Fehlerbehandlung bei der Eingabe
- Nutze Konstanten für häufig verwendete Werte (z.B. `const int OCTET_COUNT = 4`)

## Testfälle

1. IP: 192.168.1.100/24

   - Netzwerk: 192.168.1.0
   - Broadcast: 192.168.1.255

2. IP: 192.168.177.134/20
   - Netzwerk: 192.168.176.0
   - Broadcast: 192.168.191.255

## Optional

- Implementiere eine Funktion zur Validierung privater IP-Bereiche
- Füge eine Funktion zur Berechnung der Subnetz-Maske in Dezimalnotation hinzu
- Erweitere das Programm um IPv6-Unterstützung
