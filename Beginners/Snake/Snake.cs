public class Snake
{
  public List<Point> Body { get; set; }
  public int Direction { get; set; }

  public const int UP = 0;
  public const int DOWN = 1;
  public const int LEFT = 2;
  public const int RIGHT = 3;

  public Snake(Point start)
  {
    Body = new List<Point>();
    Body.Add(start);
  }

  public Boolean Contains(Point position)
  {
    for (int i = 0; i < Body.Count; i++)
    {
      if (position.Equals(Body[i]))
      {
        return true;
      }
    }
    return false;
  }

  public Boolean HitWall(int width, int height)
  {
    // nur Kopf muss überprüft werden
    if (Body[0].X < 0 || Body[0].X > width - 1 || Body[0].Y < 0 || Body[0].Y > height - 1)
    {
      return true;
    }
    return false;
  }

  public Boolean HitSelf()
  {
    for (int i = 1; i < Body.Count - 1; i++)
    {
      if (Body[0].Equals(Body[i]))
      {
        return true;
      }
    }
    return false;
  }

  public void ChangeDirection(int newDir)
  {
    // UP <-> DOWN geht nicht       RIGHT <-> LEFT geht nicht
    if (Direction + newDir != 1 && Direction + newDir != 5)
    {
      Direction = newDir;
    }
  }

  // Bewegen: Grow + Schwanz abschneiden
  // Essen: Grow

  public void Grow()
  {
    int x = Body[0].X, y = Body[0].Y;
    switch (Direction)
    {
      case UP:
        y -= 1;
        break;
      case DOWN:
        y += 1;
        break;
      case LEFT:
        x -= 1;
        break;
      default:
        x += 1;
        break;
    }
    Body.Insert(0, new Point(x, y));
  }

  public void CutTail()
  {
    Body.RemoveAt(Body.Count - 1);
  }
}