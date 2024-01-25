// install ScottPlot
// via dotnet add package ScottPlot

List<Datapoint> testDatapoints = new List<Datapoint>();
testDatapoints.Add(new Datapoint(new double[] { 26, 46 }, "1"));
testDatapoints.Add(new Datapoint(new double[] { 25, 69 }, "0"));

Knn knn = new Knn("knn.csv", 3);
Kmeans kmeans = new Kmeans("knn.csv", 2);
kmeans.Cluster();
kmeans.PrintCentroids(true);
Datapoint.PlotData(kmeans.Dataset.Datapoints.ToArray(), "debug/kmeans.png");
Datapoint.PlotData(kmeans.Centroids.ToArray(), "debug/kmeans_centroids.png");

foreach (var datapoint in testDatapoints)
{
  Console.WriteLine($"Datapoint: {datapoint}");
  Console.WriteLine($"\tKNN: {knn.Classify(datapoint)}");
  Console.WriteLine($"\tKMeans: {kmeans.Classify(datapoint)}");
}