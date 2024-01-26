using ScottPlot;
using ScottPlot.Plottables;
public class Datapoint
{
    public double[] Features { get; set; }
    public double[] NormalizedFeatures { get; set; }
    public string Label { get; set; }
    public Datapoint(double[] features, string label)
    {
        Features = features;
        Label = label;
        NormalizedFeatures = new double[Features.Length];
    }

    public void Normalize(Datapoint minimums, Datapoint maximums)
    {
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
    public static void PlotData(Datapoint[] Datapoints, string filePath, int width = 800, int height = 600)
    {
        Plot myPlot = new();
        ScottPlot.Colormaps.Tempo possibleColors = new();
        MarkerShape[] possibleShapes = Enum.GetValues(typeof(MarkerShape)).Cast<MarkerShape>().ToArray();

        string[] labels = Datapoints.Select(d => d.Label).Distinct().ToArray();
        Color[] colors = new Color[labels.Length];
        MarkerShape[] shapes = new MarkerShape[labels.Length];

        Random rand = new();

        for (int i = 0; i < colors.Length; i++)
        {
            colors[i] = possibleColors.GetColor(rand.NextDouble());
            shapes[i] = possibleShapes[(i + 1) % possibleShapes.Length];
        }
        for (int i = 0; i < labels.Length; i++)
        {
            var datapoints = Datapoints.Where(d => d.Label == labels[i]);
            double[] x = datapoints.Select(d => d.Features[0]).ToArray();
            double[] y = datapoints.Select(d => d.Features[1]).ToArray();
            Marker marker = null;
            for (int j = 0; j < x.Length; j++)
            {
                marker = myPlot.Add.Marker(x[j], y[j], shapes[i], size: 8, color: colors[i]);
            }
            if (marker != null)
            {
                marker.Label = labels[i];
            }
        }
        myPlot.ShowLegend(Alignment.UpperRight);
        myPlot.SavePng(filePath, width, height);
    }
}