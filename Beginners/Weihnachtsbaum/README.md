# Übung: ASCII-Weihnachtsbaum (Verschachtelte Schleifen)

## Ziel

In dieser Übung wirst du einen ASCII-Weihnachtsbaum mit verschachtelten `for`-Schleifen erstellen. Dabei lernst du, wie man mit Leerzeichen und Zeichen arbeitet, um symmetrische Formen zu erzeugen. Die Übung vertieft dein Verständnis für verschachtelte Schleifen und Berechnungen zur Zentrierung von Ausgaben.

## Was wirst du lernen?

- Verschachtelte `for`-Schleifen zur Erstellung von Mustern
- Berechnung von Leerzeichen für die Zentrierung
- Wiederholung von Zeichen zur Erstellung von Formen
- Kombination von verschiedenen Schleifendurchläufen für komplexe Ausgaben

## Visualisierung des Weihnachtsbaums

Ein Weihnachtsbaum mit einer Baumkrone der Höhe 5 sieht so aus:

```
    *
   ***
  *****
 *******
*********
   ###
   ###
```

**Aufbau:**
- **Krone:** Die Krone besteht aus mehreren Zeilen. Jede Zeile hat:
  - Führende Leerzeichen (für die Zentrierung)
  - Sterne (`*`)
- **Stamm:** Der Stamm ist immer 2 Zeilen hoch und 3 Zeichen breit (`###`)

## Die Mathematik hinter dem Baum

### Krone
Für eine Krone der Höhe `h` gilt für jede Zeile `i` (von 0 bis h-1):

- **Anzahl der Leerzeichen:** `h - i - 1`
- **Anzahl der Sterne:** `2 * i + 1`

**Beispiel für Höhe 5:**

| Zeile (i) | Leerzeichen | Sterne | Ausgabe      |
|-----------|-------------|--------|--------------|
| 0         | 4           | 1      | `    *`      |
| 1         | 3           | 3      | `   ***`     |
| 2         | 2           | 5      | `  *****`    |
| 3         | 1           | 7      | ` *******`   |
| 4         | 0           | 9      | `*********`  |

### Stamm
Der Stamm ist immer gleich:
- **Leerzeichen:** `h - 2` (damit er zentriert unter der Krone steht)
- **Rauten:** `3` (immer `###`)
- **Zeilen:** `2` (immer 2 Zeilen hoch)

## Anforderungen

Erstelle ein Programm, das einen ASCII-Weihnachtsbaum zeichnet:

### 1. **Begrüßung und Höhe erfragen**
   - Begrüße den Benutzer mit einer passenden Nachricht.
   - Frage nach der Höhe der Baumkrone (z.B. 5 für das Beispiel oben).
   - Verwende `Console.ReadLine()` und `Convert.ToInt32()` für die Eingabe.

### 2. **Baumkrone zeichnen**
   - Verwende eine `for`-Schleife für jede Zeile der Krone (von 0 bis Höhe-1).
   - Für jede Zeile:
     - Berechne die Anzahl der Leerzeichen: `hoehe - i - 1`
     - Gib die Leerzeichen aus (mit einer inneren `for`-Schleife oder Stringwiederholung)
     - Berechne die Anzahl der Sterne: `2 * i + 1`
     - Gib die Sterne aus (mit einer inneren `for`-Schleife oder Stringwiederholung)
     - Mache einen Zeilenumbruch mit `Console.WriteLine()`

### 3. **Baumstamm zeichnen**
   - Der Stamm ist immer 2 Zeilen hoch.
   - Jede Zeile des Stamms hat:
     - Leerzeichen zur Zentrierung: `hoehe - 2`
     - Drei Rauten: `###`
   - Verwende eine `for`-Schleife, um die 2 Zeilen zu zeichnen.

## Code-Beispiele

### Zeichen wiederholen mit einer Schleife

```csharp
// 5 Sterne ausgeben
for (int j = 0; j < 5; j++)
{
    Console.Write("*");
}
Console.WriteLine(); // Zeilenumbruch
```

Dies gibt aus:
```
*****
```

### Eine vollständige Zeile der Krone

```csharp
int hoehe = 5;
int i = 2; // Beispiel: Zeile 2

// Leerzeichen ausgeben
int anzahlLeerzeichen = hoehe - i - 1;
for (int j = 0; j < anzahlLeerzeichen; j++)
{
    Console.Write(" ");
}

// Sterne ausgeben
int anzahlSterne = 2 * i + 1;
for (int j = 0; j < anzahlSterne; j++)
{
    Console.Write("*");
}

Console.WriteLine(); // Zeilenumbruch
```

Dies gibt aus:
```
  *****
```

## Tipps

- Verwende `Console.Write()` für Zeichen ohne Zeilenumbruch und `Console.WriteLine()` für den Zeilenumbruch am Ende einer Zeile.
- Die Formeln sind wichtig:
  - Leerzeichen Krone: `hoehe - i - 1`
  - Sterne: `2 * i + 1`
  - Leerzeichen Stamm: `hoehe - 2`
- Du brauchst insgesamt 3 Schleifen:
  1. Äußere Schleife für die Zeilen der Krone
  2. Äußere Schleife für die Zeilen des Stamms
  3. Innere Schleifen für das Wiederholen von Leerzeichen und Sternen/Rauten

## Optional

- **Weihnachtskugeln:** Ersetze zufällige Sterne in der Krone durch `O` (Kugeln).
- **Mehrfarbig:** Verwende `Console.ForegroundColor`, um die Krone grün und die Kugeln rot zu färben.
- **Mehrere Bäume:** Zeichne mehrere Bäume nebeneinander.
- **Spitze mit anderem Zeichen:** Verwende für die oberste Spitze ein anderes Zeichen, z.B. `+` statt `*`.
- **Variabler Stamm:** Lass den Benutzer auch die Höhe des Stamms eingeben.
