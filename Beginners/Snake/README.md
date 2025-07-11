# Übung: Snake-Spiel in C# mit Konsolenausgabe

## Ziel

Entwickle ein klassisches Snake-Spiel als Konsolenapplikation in C#. Der Spieler steuert eine Schlange, die Nahrung sammelt und dabei wächst, ohne gegen Wände oder sich selbst zu stoßen.

## Lernziele

- Anwendung objektorientierter Programmierung (OOP)
- Implementierung von Spiellogik und Benutzerinteraktion
- Arbeit mit der Konsole für grafische Darstellung
- Verwendung von Listen zur Datenverwaltung
- Anwendung von Schleifen und Bedingungen für Spielmechaniken

## Anforderungen

### 1. Grundstruktur

1. Erstelle eine Klasse `Point` zur Repräsentation von Koordinaten

   - Eigenschaften für X- und Y-Koordinaten
   - Methode zum Vergleichen von Punkten

2. Erstelle eine Klasse `Snake` für die Spielfigur

   - Liste von Punkten (`List<Point>`) für den Schlangenkörper
   - Konstanten für die Bewegungsrichtungen (UP, DOWN, LEFT, RIGHT)
   - Methoden zur Bewegung und Kollisionserkennung

3. Erstelle eine Klasse `Food` für die Nahrung

   - Position als Punkt
   - Methode zur Generierung neuer Nahrung an zufälliger Position

4. Erstelle eine Klasse `Game` zur Steuerung des Spielablaufs
   - Spielfeld-Dimensionen
   - Verwaltung von Schlange und Nahrung
   - Spielschleife mit Eingabebehandlung, Aktualisierung und Zeichnen

### 2. Spiellogik

1. **Initialisierung**:

   - Erstelle eine Schlange mit Startposition in der Mitte des Spielfelds
   - Generiere Nahrung an zufälliger Position

2. **Spielschleife**:

   - Verarbeite Benutzereingaben (Pfeiltasten zur Steuerung)
   - Aktualisiere die Spielelemente (Schlangenbewegung, Kollisionsprüfung)
   - Zeichne das Spielfeld und alle Elemente

3. **Bewegung der Schlange**:

   - Implementiere die Wachstumsmethode (neuer Kopf in Bewegungsrichtung)
   - Implementiere das Kürzen des Schwanzes (wenn keine Nahrung aufgenommen wurde)
   - Verwende die Liste, um Körperteile der Schlange zu verwalten

4. **Kollisionserkennung**:

   - Prüfe auf Kollision mit Wänden
   - Prüfe auf Kollision mit dem eigenen Körper (Durchlaufen der Liste)
   - Prüfe auf Kollision mit Nahrung

5. **Spielende**:
   - Beende das Spiel bei Kollision mit Wand oder eigenem Körper
   - Zeige den erreichten Punktestand an

### 3. Grafische Darstellung

1. Zeichne einen Rahmen um das Spielfeld
2. Stelle die Schlange als Kette von "O"-Zeichen dar (für jedes Element in der Liste)
3. Stelle die Nahrung als "@"-Zeichen dar
4. Aktualisiere die Anzeige nach jeder Bewegung

## Implementierungsschritte

1. **Klasse Point**

   - Erstelle eine Klasse mit X- und Y-Koordinaten
   - Implementiere eine Equals-Methode zum Vergleichen von Punkten

2. **Klasse Snake**

   - Erstelle eine Liste für den Schlangenkörper
   - Implementiere Methoden zum Wachsen und Kürzen der Schlange
   - Füge Methoden zur Kollisionserkennung hinzu

3. **Klasse Food**

   - Implementiere die Positionierung von Nahrung
   - Stelle sicher, dass Nahrung nicht auf der Schlange erscheint

4. **Klasse Game**

   - Erstelle die Spielschleife
   - Implementiere die Eingabebehandlung
   - Füge die Zeichenroutinen hinzu

5. **Hauptprogramm**
   - Erstelle eine Instanz der Game-Klasse und starte das Spiel

## Listen in C# - Erklärung

In diesem Projekt wird die generische Listenklasse `List<T>` verwendet, um die Körperteile der Schlange zu verwalten. Listen sind eine grundlegende Datenstruktur in C#, die es ermöglicht, Elemente dynamisch zu speichern und zu manipulieren.

### Grundlagen zu Listen

- **Definition**: Eine Liste ist eine geordnete Sammlung von Elementen des gleichen Typs, deren Größe dynamisch angepasst werden kann.
- **Namespace**: Listen sind im Namespace `System.Collections.Generic` definiert.
- **Deklaration**: `List<T>`, wobei T der Typ der Elemente ist (in unserem Fall `Point`).

### Wichtige Eigenschaften und Methoden von Listen

1. **Erstellen einer Liste**:

   ```csharp
   List<Point> Body = new List<Point>();
   ```

2. **Hinzufügen von Elementen**:

   ```csharp
   Body.Add(new Point(x, y));        // Fügt am Ende hinzu
   Body.Insert(0, new Point(x, y));  // Fügt an Position 0 (Anfang) ein
   ```

3. **Entfernen von Elementen**:

   ```csharp
   Body.RemoveAt(Body.Count - 1);    // Entfernt das letzte Element
   Body.Remove(element);             // Entfernt ein bestimmtes Element
   ```

4. **Zugriff auf Elemente**:

   ```csharp
   Point head = Body[0];             // Zugriff auf das erste Element
   ```

5. **Anzahl der Elemente**:

   ```csharp
   int length = Body.Count;          // Gibt die Anzahl der Elemente zurück
   ```

6. **Durchlaufen einer Liste**:

   ```csharp
   // Mit foreach-Schleife
   foreach (Point bodyPart in Body)
   {
       // Operationen mit bodyPart
   }

   // Mit for-Schleife und Index
   for (int i = 0; i < Body.Count; i++)
   {
       Point bodyPart = Body[i];
       // Operationen mit bodyPart
   }
   ```

### Anwendung im Snake-Spiel

Im Snake-Spiel wird eine Liste verwendet, um:

1. **Den Schlangenkörper zu repräsentieren**:

   - Jedes Element der Liste ist ein `Point`-Objekt, das eine Position im Spielfeld darstellt.
   - Das erste Element (Index 0) ist der Kopf der Schlange.
   - Die restlichen Elemente bilden den Körper.

2. **Wachstum der Schlange zu implementieren**:

   - Beim Wachsen wird ein neuer Punkt am Anfang der Liste eingefügt (`Insert(0, newHead)`).
   - Wenn keine Nahrung aufgenommen wurde, wird das letzte Element entfernt (`RemoveAt(Body.Count - 1)`).

3. **Kollisionen zu erkennen**:
   - Durch Durchlaufen der Liste kann geprüft werden, ob der Kopf mit einem Körperteil kollidiert.
   - Mit der `Contains`-Methode kann geprüft werden, ob ein bestimmter Punkt bereits Teil der Schlange ist.

Diese Verwendung von Listen ist ein gutes Beispiel für die dynamische Datenverwaltung in C# und zeigt, wie objektorientierte Konzepte in der Spieleprogrammierung angewendet werden können.

## Hinweise zur Implementierung

- Verwende `List<Point>` für die Verwaltung des Schlangenkörpers
- Nutze `Console.SetCursorPosition()` für die Positionierung von Elementen
- Verwende `Console.KeyAvailable` und `Console.ReadKey()` für die Eingabebehandlung
- Setze `Console.CursorVisible = false` für eine bessere Darstellung
- Verwende `Thread.Sleep()` für die Steuerung der Spielgeschwindigkeit
