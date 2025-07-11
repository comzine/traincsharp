public class Game
{
  public int Width { get; set; }
  public int Height { get; set; }
  public Boolean GameRunning { get; set; }
  public Food MyFood { get; set; }
  public Snake MySnake { get; set; }
  public int Score { get; set; }

  public Game()
  {
    Width = 12;
    Height = 10;
    GameRunning = false;
    Score = 0;
    MySnake = new Snake(new Point(Width / 2, Height / 2));
    MyFood = new Food(MySnake, Width, Height);
    Console.CursorVisible = false;
    //Console.SetWindowSize(Width + 3, Height + 3);
  }

  public void Start()
  {
    GameRunning = true;
    while (GameRunning)
    {
      HandleInput();
      Update();
      Draw();
      Thread.Sleep(500);
    }
  }

  public void Update()
  {
    MySnake.Grow();
    if (MySnake.HitWall(Width, Height) || MySnake.HitSelf())
    {
      GameRunning = false;
      return;
    }
    if (MyFood.IsEatenBy(MySnake))
    {
      MyFood.GenerateNew(MySnake, Width, Height);
      Score += 10;
    }
    else
    {
      MySnake.CutTail();
    }
  }

  public void HandleInput()
  {
    if (Console.KeyAvailable)
    {
      ConsoleKeyInfo key = Console.ReadKey(true);

      switch (key.Key)
      {
        case ConsoleKey.UpArrow:
          MySnake.ChangeDirection(Snake.UP);
          break;
        case ConsoleKey.DownArrow:
          MySnake.ChangeDirection(Snake.DOWN);
          break;
        case ConsoleKey.LeftArrow:
          MySnake.ChangeDirection(Snake.LEFT);
          break;
        case ConsoleKey.RightArrow:
          MySnake.ChangeDirection(Snake.RIGHT);
          break;
        case ConsoleKey.Escape:
          GameRunning = false;
          break;
        default:
          break;
      }
    }
  }

  public void Draw()
  {
    Console.Clear();
    // Feld zeichnen
    for (int x = 0; x < Width + 2; x++)
    {
      Console.SetCursorPosition(x, 0);
      Console.Write("#");
      Console.SetCursorPosition(x, Height + 1);
      Console.Write("#");
    }

    for (int y = 0; y < Height + 2; y++)
    {
      Console.SetCursorPosition(0, y);
      Console.Write("#");
      Console.SetCursorPosition(Width + 1, y);
      Console.Write("#");
    }
    // Schlange zeichnen
    foreach (Point bodyPart in MySnake.Body)
    {
      Console.SetCursorPosition(bodyPart.X + 1, bodyPart.Y + 1);
      Console.Write("O");
    }
    // Essen zeichnen
    Console.SetCursorPosition(MyFood.Position.X + 1, MyFood.Position.Y + 1);
    Console.Write("@");
  }

}