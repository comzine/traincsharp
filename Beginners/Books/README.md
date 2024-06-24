# Übung: Buch-Klasse

## Ziel
Entwickle eine Buch-Klasse in C#, mit der man Buchinformationen speichern und verwalten kann.

## Anforderungen
1. **Book-Klasse**: Erstelle eine Klasse namens `Book` mit den folgenden Eigenschaften und Methoden:
   - Attribute:
     - `title` (Titel) vom Typ `string`
     - `author` (Autor) vom Typ `string`
     - `publicationYear` (Erscheinungsjahr) vom Typ `int`
     - `isbn` (ISBN-Nummer) vom Typ `string`
     - `pageCount` (Seitenanzahl) vom Typ `int`
   - Konstruktor:
     - `Book(string title, string author, int publicationYear, string isbn, int pageCount)`: Initialisiert eine neue Instanz der Book-Klasse mit den angegebenen Werten für Titel, Autor, Erscheinungsjahr, ISBN und Seitenanzahl.
   - Methoden:
     - `GetAgeInYears()`: Berechnet das Alter des Buches in Jahren basierend auf dem aktuellen Jahr und dem Erscheinungsjahr. Gibt das Ergebnis als `int` zurück. Tipp: Verwende die `DateTime.Now.Year`-Eigenschaft, um das aktuelle Jahr zu erhalten.
     - `ToString()`: Gibt eine Zeichenfolge zurück, die das Buch mit Titel, Autor und Erscheinungsjahr repräsentiert (z.B. "'Der Herr der Ringe' von J.R.R. Tolkien (1954)").

2. **Buch-Operationen**: Führe die folgenden Operationen durch:
   - Erstelle zwei Buch-Objekte (`book1` und `book2`) mit unterschiedlichen Titeln, Autoren, Erscheinungsjahren, ISBNs und Seitenanzahlen.
   - Berechne das Alter beider Bücher in Jahren.
   - Gib die Buchinformationen und das Alter für beide Bücher auf der Konsole aus.

## Beispielausgabe
```
'Der Herr der Ringe' von J.R.R. Tolkien (1954)
Alter: 69 Jahre

'Harry Potter und der Stein der Weisen' von J.K. Rowling (1997)
Alter: 26 Jahre
```

## Optional

- Implementiere eine Methode `HasMorePagesThan(Book otherBook)`, die überprüft, ob das aktuelle Buch mehr Seiten hat als das übergebene Buch. Gibt das Ergebnis als `bool` zurück.