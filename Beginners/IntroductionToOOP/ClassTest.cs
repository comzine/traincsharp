class ClassTest
{
  private Student student;
  private float grade;
  private float points;

  public ClassTest(Student student)
  {
    this.student = student;
  }

  public void CalculateGrade(float points, float maxPoints)
  {
    this.points = points;
    this.grade = 6.0f - 5.0f * (points / maxPoints);
  }

  public Student GetStudent()
  {
    return this.student;
  }

  public float GetGrade()
  {
    return this.grade;
  }

  public float GetPoints()
  {
    return this.points;
  }
}