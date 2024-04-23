class StudentClass
{
  private string name;
  private Student[] students;
  private int studentCount;

  public StudentClass(string name)
  {
    this.name = name;
    this.students = new Student[32];
    this.studentCount = 0;
  }

  public void AddStudent(Student student)
  {
    this.students[this.studentCount] = student;
    this.studentCount++;
    student.SetStudentClass(this);
  }

  public void PrintStudents()
  {
    Console.WriteLine("Students in class " + this.name + ":");
    for (int i = 0; i < this.studentCount; i++)
    {
      this.students[i].Print();
    }
  }

}