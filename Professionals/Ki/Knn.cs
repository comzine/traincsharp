public class Knn
{
  public Dataset Dataset { get; set; }
  public int K { get; set; }

  public Knn(string filePath, int k)
  {
    Dataset = new Dataset();
    Dataset.Load(filePath);
    Dataset.Normalize();
    K = k;
  }

  public string Classify(double[] values)
  {
    Datapoint datapoint = new Datapoint(values, "");
    return Classify(datapoint);
  }
  public string Classify(Datapoint datapoint)
  {
    Dataset.Normalize(datapoint);
    var distances = new List<Tuple<double, string>>();
    foreach (var other in Dataset.Datapoints)
    {
      distances.Add(new Tuple<double, string>(datapoint.NormalizedDistanceTo(other), other.Label));
    }
    var kNearest = distances.OrderBy(d => d.Item1).Take(K);
    var counts = new Dictionary<string, int>();
    foreach (var nearest in kNearest)
    {
      if (!counts.ContainsKey(nearest.Item2))
      {
        counts.Add(nearest.Item2, 0);
      }
      counts[nearest.Item2]++;
    }
    return counts.OrderByDescending(c => c.Value).First().Key;
  }
}
