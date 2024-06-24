# Übung: Bankkonto-Klasse

## Ziel
Entwickle eine Bankkonto-Klasse in C#, mit der man Bankkonten erstellen, Geld einzahlen, abheben und den Kontostand überprüfen kann.

## Anforderungen
1. **BankAccount-Klasse**: Erstelle eine Klasse namens `BankAccount` mit den folgenden Eigenschaften und Methoden:
   - Attribute:
     - `accountNumber` (Kontonummer) vom Typ `string`
     - `balance` (Kontostand) vom Typ `decimal`
   - Konstruktor:
     - `BankAccount(string accountNumber)`: Initialisiert eine neue Instanz der BankAccount-Klasse mit der angegebenen Kontonummer und einem Anfangsguthaben von 0.
   - Methoden:
     - `Deposit(decimal amount)`: Erhöht den Kontostand um den angegebenen Betrag.
     - `Withdraw(decimal amount)`: Verringert den Kontostand um den angegebenen Betrag, sofern genügend Guthaben vorhanden ist. Gibt `true` zurück, wenn die Abhebung erfolgreich war, andernfalls `false`.
     - `GetBalance()`: Gibt den aktuellen Kontostand zurück.

2. **Bankkonto-Operationen**: Führe die folgenden Operationen durch:
   - Erstelle zwei Bankkonten (`account1` und `account2`) mit unterschiedlichen Kontonummern.
   - Zahle einen Betrag von 500 auf `account1` ein.
   - Versuche, einen Betrag von 200 von `account2` abzuheben (sollte fehlschlagen).
   - Zahle einen Betrag von 1000 auf `account2` ein.
   - Hebe einen Betrag von 750 von `account2` ab.
   - Gib den Kontostand von `account1` und `account2` auf der Konsole aus.

## Beispielausgabe
```
Account 1 balance: 500
Account 2 balance: 250
```

## Optional
- Füge eine Eigenschaft `Owner` (Kontoinhaber) vom Typ `string` zur BankAccount-Klasse hinzu und passe den Konstruktor entsprechend an.
- Implementiere eine Methode `Transfer(BankAccount destinationAccount, decimal amount)`, mit der man Geld von einem Konto auf ein anderes überweisen kann.
