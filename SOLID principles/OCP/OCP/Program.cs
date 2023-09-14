namespace OCP;

internal class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle
        {
            Width = 100,
            Height = 100,
        };

        Circle cir = new Circle
        {
            Radius = 50,
        };

        Shape[] shapeList = { rect, cir };

        Console.WriteLine(Caculator.GetTotalArea(shapeList));
        Console.WriteLine(rect.GetArea());
        Console.WriteLine(cir.GetArea());
    }

    
}

public class Caculator
{
    public static double GetTotalArea(Shape[] shape)
    {
        double area = 0;
        foreach (Shape s in shape)
        {
            area += s.Area;
        }
        return area;
    }
}

public abstract class Shape
{
    public abstract double GetArea();
    public abstract double Area { get; }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public override double Area { get { return Width * Height; } }
    public override double GetArea()
    {
        return (Width * Height);
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }
    public override double GetArea() => Radius * Radius * Math.PI;

    public override double Area => Radius * Radius * Math.PI;

}