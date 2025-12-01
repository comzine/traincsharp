# Übung: Zinsrechner mit Kapitalentwicklung

## Ziel

Das Ziel dieser Übung ist es, ein Konsolenprogramm in C# zu erstellen, das die Entwicklung eines Kapitals über mehrere Jahre berechnet und als Tabelle darstellt. Dabei lernst du den Datentyp `double` für Dezimalzahlen, formatierte Ausgaben mit `:F2` und tabellarische Darstellungen kennen.

## Was ist double?

Der Datentyp `double` in C# wird für Zahlen mit Nachkommastellen (Gleitkommazahlen) verwendet. Im Gegensatz zu `int`, der nur ganze Zahlen speichern kann, erlaubt `double` Berechnungen mit Dezimalzahlen.

**Beispiel:**

```csharp
double preis = 19.99;
double zinssatz = 3.5;
double ergebnis = 100.0 / 3;  // ergebnis = 33.333...

Console.WriteLine(preis);     // Ausgabe: 19,99
Console.WriteLine(ergebnis);  // Ausgabe: 33,33333333333333
```

**Wichtig:**

- `double` verwendet etwa 15-16 signifikante Stellen
- Für Geldbeträge in echten Anwendungen verwendet man `decimal`, aber für Übungen reicht `double`
- Bei der Eingabe von Dezimalzahlen muss der Benutzer ein Komma verwenden (deutsche Einstellung)

## Formatierung mit :F2

Wenn du eine Zahl mit einer bestimmten Anzahl von Nachkommastellen ausgeben möchtest, verwendest du Formatierungsangaben:

```csharp
double betrag = 1234.5678;

Console.WriteLine(betrag);              // 1234,5678
Console.WriteLine("{0:F2}", betrag);    // 1234,57 (2 Nachkommastellen, gerundet)
Console.WriteLine("{0:F0}", betrag);    // 1235 (keine Nachkommastellen, gerundet)
```

**Erklärung:**

- `{0}` ist ein Platzhalter für den ersten Wert nach dem Komma
- `:F2` bedeutet "Fixed-Point mit 2 Dezimalstellen"
- Die Zahl wird automatisch gerundet

## Tabellarische Ausgabe

Für eine saubere Tabellenausgabe kannst du Tabulatoren (`\t`) und Formatierungsbreiten verwenden:

```csharp
// Mit Tabulatoren
Console.WriteLine("Jahr\tZinsen\tKapital");
Console.WriteLine("1\t50,00\t1050,00");

// Mit fester Breite (rechtsbündig)
Console.WriteLine("{0,6}{1,10}{2,12}", "Jahr", "Zinsen", "Kapital");
Console.WriteLine("{0,6}{1,10:F2}{2,12:F2}", 1, 50.0, 1050.0);
```

**Erklärung:**

- `\t` fügt einen Tabulator ein (fester Abstand)
- `{0,6}` bedeutet: erste Variable, 6 Zeichen breit (rechtsbündig)
- `{1,10:F2}` bedeutet: zweite Variable, 10 Zeichen breit, 2 Dezimalstellen

## Anforderungen

Erstelle ein Programm, das folgende Aufgaben löst:

### 1. **Begrüßung und Eingabe**

- Begrüße den Benutzer und erkläre kurz, was das Programm macht.
- Frage nach dem Startkapital (z.B. 1000).
- Frage nach dem Zinssatz in Prozent (z.B. 5 für 5%).
- Frage nach der Anzahl der Jahre (z.B. 10).
- Verwende `Convert.ToDouble()` für Kapital und Zinssatz, `Convert.ToInt32()` für Jahre.

### 2. **Zinsberechnung für ein Jahr**

- Berechne die Zinsen für das erste Jahr: `zinsen = kapital / 100 * zinssatz`
- Berechne das neue Kapital: `kapitalneu = kapital + zinsen`
- Gib das Ergebnis formatiert aus.

### 3. **Tabelle für mehrere Jahre**

- Erstelle eine Kopfzeile mit "Jahr", "Zinsen" und "Kapital".
- Verwende eine `for`-Schleife, um die Berechnung für jedes Jahr durchzuführen.
- In jedem Durchlauf: Berechne Zinsen, addiere zum Kapital, gib eine Tabellenzeile aus.
- Formatiere die Zahlen mit 2 Dezimalstellen.

### 4. **Zusammenfassung**

- Gib am Ende das Endkapital und den Gesamtgewinn (Endkapital - Startkapital) aus.

## Code-Skelett

Hier ist ein grundlegendes Gerüst für dein Programm:

```csharp
Console.WriteLine("=== Zinsrechner ===\n");
Console.WriteLine("Dieses Programm berechnet die Entwicklung deines Kapitals über mehrere Jahre.\n");

// Variablen für die Berechnung
double kapital, zinsen, zinssatz;
int jahre;

// Aufgabe 1: Eingabe der Werte
Console.Write("Startkapital: ");
string eingabe = Console.ReadLine();
kapital = Convert.ToDouble(eingabe);

Console.Write("Zinssatz in %: ");
// TODO: Lies den Zinssatz ein

Console.Write("Anzahl Jahre: ");
// TODO: Lies die Anzahl der Jahre ein

double startkapital = kapital;  // Merke dir das Startkapital für die Zusammenfassung

Console.WriteLine();  // Leerzeile

// Aufgabe 2 & 3: Tabelle ausgeben
Console.WriteLine("{0,6}{1,12}{2,14}", "Jahr", "Zinsen", "Kapital");
Console.WriteLine(new string('-', 32));  // Trennlinie

// TODO: Implementiere die for-Schleife für die Jahresberechnung
// for (int jahr = 1; jahr <= jahre; jahr++)
// {
//     // Berechne die Zinsen für dieses Jahr
//     // zinsen = ...
//
//     // Addiere die Zinsen zum Kapital
//     // kapital = ...
//
//     // Gib die Tabellenzeile aus
//     // Console.WriteLine("{0,6}{1,12:F2}{2,14:F2}", jahr, zinsen, kapital);
// }

Console.WriteLine();  // Leerzeile

// Aufgabe 4: Zusammenfassung
double gewinn = kapital - startkapital;
Console.WriteLine("Endkapital nach {0} Jahren: {1:F2}", jahre, kapital);
Console.WriteLine("Gesamtgewinn: {0:F2}", gewinn);
```

## Beispielausgabe

```text
=== Zinsrechner ===

Dieses Programm berechnet die Entwicklung deines Kapitals über mehrere Jahre.

Startkapital: 1000
Zinssatz in %: 5
Anzahl Jahre: 5

  Jahr      Zinsen       Kapital
--------------------------------
     1       50,00       1050,00
     2       52,50       1102,50
     3       55,13       1157,63
     4       57,88       1215,51
     5       60,78       1276,28

Endkapital nach 5 Jahren: 1276,28
Gesamtgewinn: 276,28
```

## Tipps

- Die Zinseszins-Formel: Jedes Jahr werden die Zinsen auf das **neue** Kapital berechnet, nicht auf das ursprüngliche.
- Speichere das Startkapital in einer separaten Variable, bevor du die Schleife startest.
- Um eine Trennlinie zu erzeugen: `Console.WriteLine(new string('-', 32));` erzeugt 32 Bindestriche.
- Achte auf die Reihenfolge in der Schleife: Erst Zinsen berechnen, dann zum Kapital addieren, dann ausgeben.
- Bei deutschen Systemeinstellungen verwendest du ein Komma für Dezimalzahlen (z.B. "5,5" für 5,5%).

## Optional

- Erweitere das Programm, sodass der Benutzer wählen kann, ob er jährliche oder monatliche Zinsen berechnen möchte.
- Füge eine Berechnung hinzu, die zeigt, nach wie vielen Jahren sich das Kapital verdoppelt hat.
- Implementiere eine Vergleichsrechnung: Der Benutzer kann zwei verschiedene Zinssätze eingeben und sieht beide Entwicklungen nebeneinander.
- Erstelle eine Grafik mit Sternen (*), die die Kapitalentwicklung visualisiert.
