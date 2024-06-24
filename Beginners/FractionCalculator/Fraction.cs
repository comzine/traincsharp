class Fraction
{
  int numerator;
  int denominator;
  public Fraction(int numerator, int denominator)
  {
    this.numerator = numerator;
    this.denominator = denominator;
  }
  public Fraction Add(Fraction f)
  {
    int n = this.numerator * f.denominator + f.numerator * this.denominator;
    int d = this.denominator * f.denominator;
    return new Fraction(n, d);
  }

  public Fraction Subtract(Fraction f)
  {
    int n = this.numerator * f.denominator - f.numerator * this.denominator;
    int d = this.denominator * f.denominator;
    return new Fraction(n, d);
  }

  public Fraction Multiply(Fraction f)
  {
    int n = this.numerator * f.numerator;
    int d = this.denominator * f.denominator;
    return new Fraction(n, d);
  }

  public Fraction Divide(Fraction f)
  {
    int n = this.numerator * f.denominator;
    int d = this.denominator * f.numerator;
    return new Fraction(n, d);
  }

  public override string ToString()
  {
    return $"{numerator}/{denominator}";
  }

  public void Simplify()
  {
    int smallest = numerator;
    if (denominator < smallest)
    {
      smallest = denominator;
    }
    // Find the greatest common divisor (not the most efficient way to do it, but it works for now)
    for (int i = 2; i < smallest; i++)
    {
      while (numerator % i == 0 && denominator % i == 0)
      {
        numerator /= i;
        denominator /= i;
      }
    }
  }
}