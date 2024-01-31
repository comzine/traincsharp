using System.Collections.Generic;
public class TreeNode
{
  public Dictionary<string, TreeNode> Children { get; set; }
  public string SplittingFeature { get; set; }
  public bool IsLeaf { get; set; }
  public string Label { get; set; } // Für Blattknoten
}

public class DataPoint
{
  public Dictionary<string, string> Features { get; set; }
  public string Label { get; set; }
}

public class DecisionTree
{
  public double CalculateGini(List<DataPoint> data)
  {
    double gini = 1.0;
    if (data.Count == 0)
    {
      return 0.0;
    }
    Dictionary<string, int> labelCounts = new Dictionary<string, int>();
    foreach (DataPoint d in data)
    {
      if (labelCounts.ContainsKey(d.Label))
      {
        labelCounts[d.Label]++;
      }
      else
      {
        labelCounts[d.Label] = 1;
      }
    }
    foreach (string label in labelCounts.Keys)
    {
      double p = labelCounts[label] / (double)data.Count;
      gini = gini - p * p;
    }
    return gini;
  }

  public double CalculateWeightedGini(List<DataPoint> data, string splittingFeature)
  {
    double weightedGini = 0.0;
    Dictionary<string, List<DataPoint>> groups = new Dictionary<string, List<DataPoint>>();
    foreach (DataPoint d in data)
    {
      if (!groups.ContainsKey(d.Features[splittingFeature].ToString()))
      {
        groups[d.Features[splittingFeature].ToString()] = new List<DataPoint>();
      }
      groups[d.Features[splittingFeature].ToString()].Add(d);
    }
    foreach (string group in groups.Keys)
    {
      weightedGini += groups[group].Count / (double)data.Count * CalculateGini(groups[group]);
    }
    return weightedGini;

  }
  public string FindBestSplittingFeature(List<DataPoint> data, List<string> features)
  {
    double bestGini = 1.0;
    string bestFeature = "";
    foreach (string feature in features)
    {
      double gini = CalculateWeightedGini(data, feature);
      if (gini < bestGini)
      {
        bestGini = gini;
        bestFeature = feature;
      }
    }
    return bestFeature;
  }

  public TreeNode BuildTree(List<DataPoint> data, List<string> features)
  {
    TreeNode node = new TreeNode();
    if (CalculateGini(data) == 0.0 || features.Count == 0)
    {
      node.IsLeaf = true;
      node.Label = data[0].Label;
      return node;
    }
    string splittingFeature = FindBestSplittingFeature(data, features);
    node.SplittingFeature = splittingFeature;
    node.Children = new Dictionary<string, TreeNode>();
    Dictionary<string, List<DataPoint>> groups = new Dictionary<string, List<DataPoint>>();
    foreach (DataPoint d in data)
    {
      if (!groups.ContainsKey(d.Features[splittingFeature].ToString()))
      {
        groups[d.Features[splittingFeature].ToString()] = new List<DataPoint>();
      }
      groups[d.Features[splittingFeature].ToString()].Add(d);
    }
    foreach (string group in groups.Keys)
    {
      List<string> newFeatures = new List<string>(features);
      newFeatures.Remove(splittingFeature);
      node.Children[group] = BuildTree(groups[group], newFeatures);
    }
    return node;
  }

  public string Predict(TreeNode node, DataPoint data)
  {
    if (node.IsLeaf)
    {
      return node.Label;
    }
    return Predict(node.Children[data.Features[node.SplittingFeature].ToString()], data);
  }

  public void PrintTree(TreeNode node, string indent = "")
  {
    if (node.IsLeaf)
    {
      System.Console.WriteLine(indent + node.Label);
      return;
    }
    System.Console.WriteLine(indent + node.SplittingFeature);
    foreach (string group in node.Children.Keys)
    {
      System.Console.WriteLine(indent + "  " + group);
      PrintTree(node.Children[group], indent + "    ");
    }
  }

  public void ReadFromCSV(string filename, out List<DataPoint> data, out List<string> features)
  {
    data = new List<DataPoint>();
    features = new List<string>();
    string[] lines = System.IO.File.ReadAllLines(filename);
    string[] header = lines[0].Split(',');
    for (int i = 1; i < header.Length; i++)
    {
      features.Add(header[i]);
    }
    for (int i = 1; i < lines.Length; i++)
    {
      string[] parts = lines[i].Split(',');
      DataPoint d = new DataPoint();
      d.Features = new Dictionary<string, string>();
      for (int j = 1; j < parts.Length; j++)
      {
        d.Features[header[j]] = parts[j];
      }
      d.Label = parts[0];
      data.Add(d);
    }
  }
}