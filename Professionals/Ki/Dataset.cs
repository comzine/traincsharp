public class Dataset
{
  public List<Datapoint> Datapoints { get; set; }

  public Dataset()
  {
    Datapoints = new List<Datapoint>();
  }
  public void Load(string filePath)
  {
    using (var reader = new StreamReader(filePath))
    {
      while (!reader.EndOfStream)
      {
        var line = reader.ReadLine();
        var values = line.Split(';');
        var datapoint = new Datapoint(values.Take(values.Length - 1).Select(double.Parse).ToArray(), values.Last());
        Add(datapoint);
      }
    }
  }
  public void Add(Datapoint datapoint)
  {
    Datapoints.Add(datapoint);
  }
  public void Normalize(Datapoint datapoint = null)
  {
    var minimum = CalcMin(this);
    var maximum = CalcMax(this);
    if (datapoint != null)
    {
      datapoint.Normalize(minimum, maximum);
    }
    else
    {
      foreach (var dp in Datapoints)
      {
        dp.Normalize(minimum, maximum);
      }
    }
  }

  private Datapoint CalcMin(Dataset dataset)
  {
    var minimums = new double[dataset.Datapoints[0].Features.Length];
    for (int i = 0; i < minimums.Length; i++)
    {
      minimums[i] = double.MaxValue;
    }
    foreach (var datapoint in dataset.Datapoints)
    {
      for (int i = 0; i < datapoint.Features.Length; i++)
      {
        if (datapoint.Features[i] < minimums[i])
        {
          minimums[i] = datapoint.Features[i];
        }
      }
    }
    return new Datapoint(minimums, "");
  }

  private Datapoint CalcMax(Dataset dataset)
  {
    var maximums = new double[dataset.Datapoints[0].Features.Length];
    for (int i = 0; i < maximums.Length; i++)
    {
      maximums[i] = double.MinValue;
    }
    foreach (var datapoint in dataset.Datapoints)
    {
      for (int i = 0; i < datapoint.Features.Length; i++)
      {
        if (datapoint.Features[i] > maximums[i])
        {
          maximums[i] = datapoint.Features[i];
        }
      }
    }
    return new Datapoint(maximums, "");
  }
}