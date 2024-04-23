class Student
{
  private string firstName;
  private string lastName;
  private float height;

  private StudentClass studentClass;

  public Student(string firstName, string lastName)
  {
    this.firstName = firstName;
    this.lastName = lastName;
    this.height = 180f;
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
}