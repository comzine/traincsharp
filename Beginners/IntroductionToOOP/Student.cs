class Student
{
  private string firstName;
  private string lastName;
  private float height;

  // Referenz auf ein (noch nicht existierendes) Objekt der Klasse StudentClass
  private StudentClass studentClass;

  private ClassTest classTest; // Grundstück

  public Student(string firstName, string lastName)
  {
    this.firstName = firstName;
    this.lastName = lastName;
    this.height = 180f;
    this.classTest = new ClassTest(this); // Baue Haus nach dem Plan der Klasse auf Grundstück classTest
  }

  public void Print()
  {
    Console.WriteLine(this.firstName + " "
    + this.lastName + " (" + this.height + " cm)");
  }

  public void Learn()
  {
    Console.WriteLine(this.firstName + " is learning.");
  }

  public void SetHeight(float height)
  {
    this.height = height;
  }

  public void SetStudentClass(StudentClass studentClass)
  {
    this.studentClass = studentClass;
  }

  public ClassTest GetClassTest()
  {
    return this.classTest;
  }

  public void PrintGrade()
  {
    Console.WriteLine($"{this.firstName} hat folgende Note: {this.GetClassTest().GetGrade():f1} ({this.GetClassTest().GetPoints():f1} Punkte)");
  }
}