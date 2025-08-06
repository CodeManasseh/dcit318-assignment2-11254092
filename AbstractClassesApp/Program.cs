public abstract class Shape
{
    public abstract double GetArea();
}
public class Circle : Shape
{
    public double Radius { get; set; }
    public Circle(double radius)
    {
        Radius = radius;
    }
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }
    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }
    public override double GetArea()
    {
        return Length * Width;
    }
}
// Abstract Classes and Methods
class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            Console.WriteLine($"Circle area: {circle.GetArea()}");
            Console.WriteLine($"Rectangle area: {rectangle.GetArea()}");
        }
    }