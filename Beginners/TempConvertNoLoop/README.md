# Übung: Temperaturumrechner (ohne Schleife)

## Ziel

Entwickle ein Konsolenprogramm in C#, das eine Temperatur zwischen Celsius und Fahrenheit umrechnet. Diese Übung konzentriert sich auf die Verwendung von `switch-case` und `if-else` Anweisungen.

## Beschreibung

Der Benutzer soll auswählen können, in welche Richtung er umrechnen möchte:
- Von Celsius nach Fahrenheit
- Von Fahrenheit nach Celsius

Anschließend gibt er die Temperatur ein und erhält das Ergebnis.

## Umrechnungsformeln

**Celsius nach Fahrenheit:**
```
F = C × 9/5 + 32
```

**Fahrenheit nach Celsius:**
```
C = (F - 32) × 5/9
```

## Die `switch`-Anweisung

Die `switch`-Anweisung ist eine Alternative zu mehreren `if-else if`-Verzweigungen. Sie eignet sich besonders gut, wenn du eine Variable gegen mehrere feste Werte prüfen möchtest.

```csharp
int auswahl = 2;

switch (auswahl)
{
    case 1:
        Console.WriteLine("Option 1 gewählt");
        break;
    case 2:
        Console.WriteLine("Option 2 gewählt");
        break;
    case 3:
        Console.WriteLine("Option 3 gewählt");
        break;
    default:
        Console.WriteLine("Ungültige Auswahl");
        break;
}
```

**Wichtig:**
- Jeder `case`-Block muss mit `break` enden (sonst läuft der Code in den nächsten Block weiter)
- `default` wird ausgeführt, wenn kein `case` passt (wie `else` bei `if`)
- Die Werte nach `case` müssen konstant sein (keine Variablen)

## Anforderungen

1. **Menü anzeigen**: Zeige dem Benutzer die verfügbaren Optionen:
   ```
   Temperaturumrechner
   [1] Celsius -> Fahrenheit
   [2] Fahrenheit -> Celsius
   Deine Auswahl:
   ```

2. **Auswahl einlesen**: Lies die Auswahl des Benutzers ein und speichere sie als `int`.

3. **Switch-Case verwenden**: Verwende eine `switch`-Anweisung, um basierend auf der Auswahl die richtige Umrechnung durchzuführen.

4. **Temperatur einlesen**: Fordere den Benutzer auf, die Temperatur einzugeben (als `double`).

5. **Berechnung durchführen**: Führe die entsprechende Umrechnung durch.

6. **Ergebnis ausgeben**: Gib das Ergebnis formatiert aus.

7. **Ungültige Eingabe behandeln**: Wenn der Benutzer eine ungültige Option wählt, gib eine Fehlermeldung aus.

## Beispiel

```
Temperaturumrechner
[1] Celsius -> Fahrenheit
[2] Fahrenheit -> Celsius
Deine Auswahl: 1

Gib die Temperatur in Celsius ein: 100
100 °C entspricht 212 °F
```

```
Temperaturumrechner
[1] Celsius -> Fahrenheit
[2] Fahrenheit -> Celsius
Deine Auswahl: 2

Gib die Temperatur in Fahrenheit ein: 32
32 °F entspricht 0 °C
```

```
Temperaturumrechner
[1] Celsius -> Fahrenheit
[2] Fahrenheit -> Celsius
Deine Auswahl: 5

Ungültige Auswahl!
```

## Optional

- Formatiere die Ausgabe auf eine Nachkommastelle (z.B. `21.5 °C`)
- Füge eine dritte Option hinzu: Kelvin nach Celsius (`C = K - 273.15`)
- Verwende String-Interpolation für die Ausgabe: `$"{celsius} °C entspricht {fahrenheit} °F"`
