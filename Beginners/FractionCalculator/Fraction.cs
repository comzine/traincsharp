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
}