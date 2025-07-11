public class Food
{
  public Point Position { get; set; }
  public Random Rand { get; set; }

  public Food(Snake snake, int width, int height)
  {
    Rand = new Random();
    GenerateNew(snake, width, height);
  }

  public void GenerateNew(Snake snake, int width, int height)
  {
    do
    {
      int x = Rand.Next(0, width);
      int y = Rand.Next(0, height);
      Position = new Point(x, y);
    } while (snake.Contains(Position));
  }

  public Boolean IsEatenBy(Snake snake)
  {
    return Position.Equals(snake.Body[0]);
  }
}