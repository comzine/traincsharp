// install ScottPlot
// via dotnet add package ScottPlot

List<Datapoint> testDatapoints = new List<Datapoint>();
testDatapoints.Add(new Datapoint(new double[] { 26, 46 }, "1"));
testDatapoints.Add(new Datapoint(new double[] { 25, 69 }, "0"));

Knn knn = new Knn("data/knn.csv", 3);
Kmeans kmeans = new Kmeans("data/knn.csv", 2, tolerance: 1);
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


/*
Kmeans kmeans = new Kmeans("data/cities_coordinates.csv", 2, false);
int iterations = kmeans.Cluster();
System.Console.WriteLine($"Iterations: {iterations}");
kmeans.PrintCentroids(false);
Datapoint.PlotData(kmeans.Centroids.ToArray(), "debug/cities_centroids.png", 500, 700);
// combine kmeans.Datapoints and kmeans.Centroids
foreach (var centroid in kmeans.Centroids)
{
  centroid.Label = $"Centroid {centroid.Label}";
}
List<Datapoint> allDatapoints = new List<Datapoint>();
allDatapoints.AddRange(kmeans.Dataset.Datapoints);
allDatapoints.AddRange(kmeans.Centroids);
Datapoint.PlotData(allDatapoints.ToArray(), "debug/cities_all.png", 500, 700);
*/