# Übung: Klassen und Objekte

## Ziel der Übung

Das Ziel dieser Übung besteht darin, ein tieferes Verständnis für Klassen und Objekte in C# zu erhalten. Du wirst eine `Student` Klasse und eine `StudentClass` Klasse schreiben, in denen du Methoden und Felder nutzt, um die Informationen der Studenten und ihrer Klassen zu verwalten.

## Anforderungen

1. Füge folgende Klassen zu deinem Projekt hinzu: `Student`, `StudentClass`, indem du die Dateien `Student.cs` und `StudentClass.cs` erstellst.

2. Erstelle eine Klasse namens `Student` mit privaten Feldern für den Vornamen, Nachnamen und die Größe des Studenten. Zusätzlich sollte es ein privates Feld für eine `StudentClass` Instanz geben.

3. Der Konstruktor der `Student` Klasse sollte zwei Parameter für Vor- und Nachnamen haben. Er sollte außerdem die Größe auf 180 setzen.

4. Die `Student` Klasse sollte Methoden zum Drucken der Informationen des Studenten, zum "Lernen" (Drucken einer Nachricht), zum Festlegen der Größe und zum Festlegen der `StudentClass` haben.

5. Erstelle eine Klasse `StudentClass` mit privaten Feldern für den Namen der Klasse, ein Array von `Student` Objekten und eine Zählvariable für die Anzahl der Studenten in der Klasse.

6. Der Konstruktor der `StudentClass` Klasse sollte einen Parameter für den Namen der Klasse haben und ein Array für bis zu 32 Studenten initialisieren, die Anzahl der Studenten sollte 0 sein.

7. Die `StudentClass` Klasse sollte Methoden zum Hinzufügen einer `Student` Instanz zu ihrer Liste von Studenten (und zum Aufrufen der `SetStudentClass` Methode auf dem `Student` Objekt) und zum Drucken aller Studenten in der Klasse haben.

8. Teste deine Klassen indem du Instanzen von `Student` und `StudentClass` erstellst und ihre Methoden aufrufst.

9. Erstelle ein UML-Klassendiagramm für die Klassen `Student` und `StudentClass`. Berücksichtige dabei die Beziehung zwischen den Klassen.

## Beispielcode

```csharp
Student max = new Student("Max", "Mustermann");
Student marie = new Student("Marie", "Musterfrau");
StudentClass beispielklasse = new StudentClass("Beispielklasse");
beispielklasse.AddStudent(max);
beispielklasse.AddStudent(marie);
beispielklasse.PrintStudents();
max.Learn();
marie.SetHeight(160);
beispielklasse.PrintStudents();

```

## Optional

* Implementiere eine Methode `RemoveStudent` in der `StudentClass` Klasse, die einen Studenten auf Basis seines Namens von der Liste entfernt.
* Erweitere die `Student` Klasse, um weitere Eigenschaften eines Studenten zu verwalten, wie z.B. die Noten.
* Ändere die Methode `PrintStudents` in der `StudentClass` Klasse, so dass sie die Studenten in alphabetischer Reihenfolge ausgibt.
