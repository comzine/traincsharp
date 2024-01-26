
public class Dataset
{
  public List<Datapoint> Datapoints { get; set; }

  public bool ShallNormalize { get; }
  public Dataset(bool shallNormalize)
  {
    Datapoints = new List<Datapoint>();
    ShallNormalize = shallNormalize;
  }

  public void Load(string filePath)
  {
    using (var reader = new StreamReader(filePath))
    {
      while (!reader.EndOfStream)
      {
        var line = reader.ReadLine();
        if (line != null)
        {
          var values = line.Split(';');
          if (values.Length < 2)
          {
            values = line.Split(',');
          }
          var datapoint = new Datapoint(values.Take(values.Length - 1).Select(double.Parse).ToArray(), values.Last());
          Datapoints.Add(datapoint);
        }
      }
    }
  }
  public void NormalizeIfRequired(Datapoint? datapoint = null)
  {
    if (!ShallNormalize)
    {
      if (datapoint != null)
      {
        datapoint.NormalizedFeatures = datapoint.Features;
      }
      else
      {
        foreach (var dp in Datapoints)
        {
          dp.NormalizedFeatures = dp.Features;
        }
      }
    }
    else
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
  }

  public void UndoNormalization(Datapoint[] datapoints)
  {
    if (ShallNormalize)
    {
      var minimum = CalcMin(this);
      var maximum = CalcMax(this);
      foreach (var datapoint in datapoints)
      {
        datapoint.Features = new double[datapoint.NormalizedFeatures.Length];
        for (int i = 0; i < datapoint.NormalizedFeatures.Length; i++)
        {
          datapoint.Features[i] = datapoint.NormalizedFeatures[i] * (maximum.Features[i] - minimum.Features[i]) + minimum.Features[i];
        }
      }
    }
    else
    {
      foreach (var datapoint in datapoints)
      {
        datapoint.Features = datapoint.NormalizedFeatures;
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