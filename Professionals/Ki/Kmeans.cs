public class Kmeans
{
    public Dataset Dataset { get; set; }
    public int K { get; set; }
    public Datapoint[] Centroids { get; set; }

    public Kmeans(string filePath, int k)
    {
        Dataset = new Dataset();
        Dataset.Load(filePath);
        Dataset.Normalize();
        Centroids = new Datapoint[k];
        for (int i = 0; i < k; i++)
        {
            Centroids[i] = Dataset.Datapoints[i];
            Centroids[i].Label = $"{i}";
        }
        K = k;
    }

    public void LabelizeDatapoints()
    {
        foreach (var datapoint in Dataset.Datapoints)
        {
            var distances = new List<Tuple<double, int>>();
            for (int i = 0; i < K; i++)
            {
                distances.Add(new Tuple<double, int>(datapoint.NormalizedDistanceTo(Centroids[i]), i));
            }
            var closest = distances.OrderBy(d => d.Item1).First().Item2;
            datapoint.Label = $"{closest}";
        }
    }

    public void CalculateCentroids()
    {
        for (int i = 0; i < K; i++)
        {
            var datapoints = Dataset.Datapoints.Where(d => d.Label == $"{i}");
            var averages = new double[Dataset.Datapoints.First().NormalizedFeatures.Length];
            foreach (var datapoint in datapoints)
            {
                for (int j = 0; j < datapoint.NormalizedFeatures.Length; j++)
                {
                    averages[j] += datapoint.NormalizedFeatures[j];
                }
            }
            for (int j = 0; j < averages.Length; j++)
            {
                averages[j] /= datapoints.Count();
            }
            Centroids[i].NormalizedFeatures = averages;
        }
    }

    public void Cluster()
    {
        while (!HasConverged())
        {
            LabelizeDatapoints();
        }
    }

    public bool HasConverged()
    {
        var oldCentroids = Centroids;
        CalculateCentroids();
        var newCentroids = Centroids;
        for (int i = 0; i < K; i++)
        {
            if (oldCentroids[i].NormalizedDistanceTo(newCentroids[i]) > 0.001)
            {
                return false;
            }
        }
        return true;
    }

    public string Classify(Datapoint datapoint)
    {
        Dataset.Normalize(datapoint);
        var distances = new List<Tuple<double, int>>();
        for (int i = 0; i < K; i++)
        {
            distances.Add(new Tuple<double, int>(datapoint.NormalizedDistanceTo(Centroids[i]), i));
        }
        var closest = distances.OrderBy(d => d.Item1).First().Item2;
        return $"{closest}";
    }

    public string Classify(double[] values)
    {
        Datapoint datapoint = new Datapoint(values, "");
        return Classify(datapoint);
    }

    public void PrintCentroids(bool withDatapoints = false)
    {
        Console.WriteLine("Centroids:");
        foreach (var centroid in Centroids)
        {
            Console.WriteLine(centroid);
            if (withDatapoints)
            {
                foreach (var datapoint in Dataset.Datapoints.Where(d => d.Label == centroid.Label))
                {
                    Console.WriteLine($"  {datapoint}");
                }
            }
        }
    }

}