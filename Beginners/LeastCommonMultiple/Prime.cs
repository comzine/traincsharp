class Prime : IComparable<Prime>
{
  private int prime;
  private int exp;

  public Prime(int prime, int exp)
  {
    this.prime = prime;
    this.exp = exp;
  }

  public Prime(int prime)
  {
    this.prime = prime;
    this.exp = 0;
  }

  public int GetPrime()
  {
    return prime;
  }

  public int GetExp()
  {
    return exp;
  }

  public void IncrementExp()
  {
    exp++;
  }

  public override string ToString()
  {
    string s = prime.ToString();
    for (int i = 0; i < exp; i++)
    {
      s += " * " + prime;
    }
    return s;
  }

  public int Calculate()
  {
    int result = 1;
    for (int i = 0; i < exp; i++)
    {
      result *= prime;
    }
    return result;
  }

  public int CompareTo(Prime other)
  {
    return prime.CompareTo(other.prime);
  }
}