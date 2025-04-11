PrimeFactorization pf1 = new PrimeFactorization(48);
PrimeFactorization pf2 = new PrimeFactorization(18);

PrimeFactorization combined = pf1.Combine(pf2);

Console.WriteLine($"Combined Prime Factorization: {combined}");
Console.WriteLine($"Combined Calculation: {combined.Calculate()}");