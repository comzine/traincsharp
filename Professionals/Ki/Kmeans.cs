public class Kmeans
{
    public Dataset Dataset { get; set; }
    public int K { get; set; }
    public Datapoint[] Centroids { get; set; }
    private double tolerance = 0.001;
    private int max_iterations = 1000;

    public Kmeans(string filePath, int k, bool shallNormalize = true, double tolerance = 0.001, int max_iterations = 1000)
    {
        Dataset = new Dataset(shallNormalize);
        Dataset.Load(filePath);
        Dataset.NormalizeIfRequired();
        Centroids = new Datapoint[k];
        for (int i = 0; i < k; i++)
        {
            Centroids[i] = Dataset.Datapoints[i];
            Centroids[i].Label = $"{i}";
        }
        K = k;
        this.tolerance = tolerance;
        this.max_iterations = max_iterations;
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

    public double CalculateCentroids()
    {
        double sumOfCentroidMovedDistances = 0;
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
            var Averages = new Datapoint(averages, "");
            Dataset.NormalizeIfRequired(Averages);
            sumOfCentroidMovedDistances += Centroids[i].NormalizedDistanceTo(Averages);
            Centroids[i].NormalizedFeatures = averages;
        }
        return sumOfCentroidMovedDistances;
    }

    public int Cluster()
    {
        int iterations = 0;
        double sumOfCentroidMovedDistances = double.MaxValue;
        while (sumOfCentroidMovedDistances > tolerance && iterations < max_iterations)
        {
            LabelizeDatapoints();
            sumOfCentroidMovedDistances = CalculateCentroids();
            iterations++;
        }
        Dataset.UndoNormalization(Centroids);
        return iterations;
    }


    public string Classify(Datapoint datapoint)
    {
        Dataset.NormalizeIfRequired(datapoint);
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