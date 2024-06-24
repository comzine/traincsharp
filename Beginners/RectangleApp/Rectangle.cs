public class Rectangle
{
  double width = 0;
  double height = 0;

  public Rectangle(double width, double height)
  {
    this.width = width;
    this.height = height;
  }

  public double GetArea()
  {
    return width * height;
  }

  public double GetPerimeter()
  {
    return 2 * (width + height);
  }

  public bool IsSquare()
  {
    return width == height;
  }

  public override string ToString()
  {
    return $"Rectangle: width={width}, height={height}";
  }
}