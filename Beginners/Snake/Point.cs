public class Point
{
  public int X { get; set; }
  public int Y { get; set; }

  public Point(int x, int y)
  {
    X = x;
    Y = y;
  }

  public Boolean Equals(Point other)
  {
    return this.X == other.X && this.Y == other.Y;
  }

}