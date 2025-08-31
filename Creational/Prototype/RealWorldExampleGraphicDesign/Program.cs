public abstract class Shape
{
    public string Color { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    public abstract Shape Clone();
}

public class Circle : Shape
{
    public int Radius { get; set; }

    public override Shape Clone()
    {
        return (Shape)this.MemberwiseClone();
    }
}

public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override Shape Clone()
    {
        return (Shape)this.MemberwiseClone();
    }
}

class Program
{
    static void Main()
    {
        // Original Circle
        Circle circle1 = new Circle { Color = "Red", X = 10, Y = 20, Radius = 15 };

        // Clone the circle
        Circle circle2 = (Circle)circle1.Clone();
        circle2.Color = "Blue";  // change only color
        circle2.X = 50;          // move it somewhere else

        Console.WriteLine($"Circle1: {circle1.Color}, Position: {circle1.X},{circle1.Y}");
        Console.WriteLine($"Circle2: {circle2.Color}, Position: {circle2.X},{circle2.Y}");
    }
}
