Student max = new Student("Max", "Mustermann");
Student marie = new Student("Marie", "Musterfrau");
StudentClass beispielklasse = new StudentClass("Beispielklasse");
beispielklasse.AddStudent(max);
beispielklasse.AddStudent(marie);
beispielklasse.PrintStudents();
max.Learn();
marie.SetHeight(160);
beispielklasse.PrintStudents();