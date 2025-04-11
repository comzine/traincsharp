
class PrimeFactorization
{
  private Dictionary<int, Prime> primeFactors;

  public PrimeFactorization(int n)
  {
    primeFactors = new Dictionary<int, Prime>();
    for (int i = 2; i <= n; i++)
    {
      while (n % i == 0)
      {
        if (!primeFactors.ContainsKey(i))
        {
          primeFactors[i] = new Prime(i);
        }
        primeFactors[i].IncrementExp();
        n /= i;
      }
    }
  }

  private PrimeFactorization(Dictionary<int, Prime> primeFactors)
  {
    this.primeFactors = new Dictionary<int, Prime>(primeFactors);
  }

  public override string ToString()
  {
    List<Prime> primes = primeFactors.Values.ToList();
    primes.Sort();
    return string.Join(" * ", primes);
  }

  public int Calculate()
  {
    int result = 1;
    foreach (Prime prime in primeFactors.Values)
    {
      result *= prime.Calculate();
    }
    return result;
  }

  public PrimeFactorization Combine(PrimeFactorization other)
  {
    Dictionary<int, Prime> combinedFactors = new Dictionary<int, Prime>();

    var keys1 = primeFactors.Keys.ToList();
    var keys2 = other.primeFactors.Keys.ToList();

    List<int> allKeys = keys1.Union(keys2).ToList();

    foreach (int key in allKeys)
    {
      Prime prime1 = primeFactors.ContainsKey(key) ? primeFactors[key] : null;
      Prime prime2 = other.primeFactors.ContainsKey(key) ? other.primeFactors[key] : null;

      if (prime1 != null && prime2 != null)
      {
        combinedFactors[key] = new Prime(key, int.Max(prime1.GetExp(), prime2.GetExp()));
      }
      else if (prime1 != null)
      {
        combinedFactors[key] = new Prime(prime1.GetPrime(), prime1.GetExp());
      }
      else if (prime2 != null)
      {
        combinedFactors[key] = new Prime(prime2.GetPrime(), prime2.GetExp());
      }
    }
    return new PrimeFactorization(combinedFactors);
  }
}