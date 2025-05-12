# Übung: Objektorientierte Programmierung mit Properties in C#

## Ziel

Entwickle eine `BankAccount`-Klasse in C#, die verschiedene Arten von Properties verwendet, um den Zugriff auf Kontodaten zu kontrollieren und zu verwalten.

## Anforderungen

1. **BankAccount-Klasse**: Erstelle eine Klasse namens `BankAccount` mit den folgenden Properties:

   - Properties:

     - `AccountNumber` (Kontonummer): Ein read-only Property vom Typ `string`.
     - `Balance` (Kontostand): Ein read-only Property vom Typ `decimal`, das den aktuellen Kontostand zurückgibt.
     - `Owner` (Kontoinhaber): Ein read-write Property vom Typ `string`.
     - `IsActive` (Aktiv): Ein read-write Property vom Typ `bool`.
     - `TransactionCount` (Anzahl der Transaktionen): Ein read-only Property vom Typ `int`, das die Anzahl der durchgeführten Transaktionen zurückgibt.

   - Backing Fields:

     - Implementiere für jedes Property das entsprechende private Attribut.

   - Konstruktor:

     - `BankAccount(string accountNumber, string owner)`: Initialisiert ein neues Bankkonto mit der angegebenen Kontonummer und dem Kontoinhaber.

   - Methoden:
     - `Deposit(decimal amount)`: Erhöht den Kontostand um den angegebenen Betrag und erhöht die Transaktionsanzahl.
     - `Withdraw(decimal amount)`: Verringert den Kontostand um den angegebenen Betrag und erhöht die Transaktionsanzahl.
     - `ToString()`: Gibt die Kontoinformationen als String zurück.

2. **Implementierungsdetails**:

   - Der Kontostand darf nicht direkt von außen geändert werden, sondern nur über die Methoden `Deposit` und `Withdraw`.
   - Die Kontonummer darf nach der Erstellung nicht mehr geändert werden.
   - Die Transaktionsanzahl soll bei jeder Ein- oder Auszahlung automatisch erhöht werden.
   - Der Setter von `Owner` soll überprüfen, dass der Name nicht leer oder null ist.

3. **Kontooperationen**: Führe in der Main-Methode der Program-Klasse folgende Operationen durch:
   - Erzeuge ein neues Bankkonto mit einer Kontonummer und einem Besitzer.
   - Tätige verschiedene Ein- und Auszahlungen auf dem Konto.
   - Ändere den Kontoinhaber und den Aktivitätsstatus.
   - Gib alle relevanten Kontoinformationen auf der Konsole aus.

## Beispielcode für die Klasse (Gerüst)

```csharp
class BankAccount
{
    // Implementiere hier alle Properties mit den dazugehörigen Backing Fields (Attribute)

    // Konstruktor

    // Methoden
}
```

## Beispielausgabe

```
Neues Konto erstellt: DE123456789 (Inhaber: Max Mustermann)
Kontostand: 0,00 €
Einzahlung: 500,00 €
Kontostand: 500,00 €
Auszahlung: 200,00 €
Kontostand: 300,00 €
Kontoinhaber geändert zu: Erika Musterfrau
Anzahl der Transaktionen: 2
Konto ist aktiv: True
```

## Bonus

- Implementiere eine zusätzliche Property `InterestRate` (Zinssatz) vom Typ `decimal` mit einem Setter, der sicherstellt, dass der Zinssatz zwischen 0% und 10% liegt.
- Füge eine Methode `ApplyInterest()` hinzu, die Zinsen basierend auf diesem Zinssatz berechnet und dem Kontostand hinzufügt.
