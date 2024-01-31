DecisionTree decisionTree = new DecisionTree();
List<DataPoint> data = new List<DataPoint>();
List<string> features = new List<string>();
decisionTree.ReadFromCSV("affen.csv", out data, out features);
List<DataPoint> trainingData = new List<DataPoint>();
List<DataPoint> testData = new List<DataPoint>();
for(int i = 0; i < data.Count; i++)
{
  if(i < data.Count * 80 / 100)
  {
    trainingData.Add(data[i]);
  }
  else
  {
    testData.Add(data[i]);
  }
}
TreeNode tree = decisionTree.BuildTree(data, features);
decisionTree.PrintTree(tree);
foreach(DataPoint d in data)
{
  System.Console.WriteLine("Predicted: " + decisionTree.Predict(tree, d) + ", Actual: " + d.Label);
}