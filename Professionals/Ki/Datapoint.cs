public class Datapoint
{
    public double[] Features { get; set; }
    public double[] NormalizedFeatures { get; set; }
    public string Label { get; set; }
    public Datapoint(double[] features, string label)
    {
        Features = features;
        Label = label;
    }

    public void Normalize(Datapoint minimums, Datapoint maximums)
    {
        NormalizedFeatures = new double[Features.Length];
        for (int i = 0; i < Features.Length; i++)
        {
            NormalizedFeatures[i] = (Features[i] - minimums.Features[i]) / (maximums.Features[i] - minimums.Features[i]);
        }
    }

    public double DistanceTo(Datapoint other)
    {
        double sumOfSquares = 0;
        for (int i = 0; i < Features.Length; i++)
        {
            sumOfSquares += Math.Pow(Features[i] - other.Features[i], 2);
        }
        return Math.Sqrt(sumOfSquares);
    }

    public double NormalizedDistanceTo(Datapoint other)
    {
        double sumOfSquares = 0;
        for (int i = 0; i < NormalizedFeatures.Length; i++)
        {
            sumOfSquares += Math.Pow(NormalizedFeatures[i] - other.NormalizedFeatures[i], 2);
        }
        return Math.Sqrt(sumOfSquares);
    }

    public override string ToString()
    {
        return $"{string.Join(",", Features)}: {Label}";
    }
}