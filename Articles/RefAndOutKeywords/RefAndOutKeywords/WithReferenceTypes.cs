namespace RefAndOutKeywords;
public class WithReferenceTypes
{

    public static void Run()
    {
        Pen pen = new Pen(Color.Blue);
        Console.WriteLine($"Before ChangeColor method: {pen.Color}");
        ChangeColor(pen);
        Console.WriteLine($"After the ChangeColor method: {pen.Color}");
        Console.WriteLine();
        Console.WriteLine($"Before CreateNewObjectWithoutRef method: {pen.Color}");
        CreateNewObjectWithoutRef(pen);
        Console.WriteLine($"After CreateNewObjectWithoutRef method: {pen.Color}");
        Console.WriteLine();
        Console.WriteLine($"Before CreateNewObjectWithRef method: {pen.Color}");
        CreateNewObjectWithRef(ref pen);
        Console.WriteLine($"After CreateNewObjectWithRef method: {pen.Color}");
        Console.ReadKey();
    }

    public static void ChangeColor(Pen pen)
    {
        pen.Color = Color.Green;
        Console.WriteLine($"Inside the ChangeColor method the color is {pen.Color}");
    }

    public static void CreateNewObjectWithoutRef(Pen pen)
    {
        pen = new Pen(Color.Red);
        Console.WriteLine($"Inside the CreateNewObjectWithoutRef method the color of new pen object is {pen.Color}");
    }

    public static void CreateNewObjectWithRef(ref Pen pen)
    {
        pen = new Pen(Color.Yellow);
        Console.WriteLine($"Inside the CreateNewObjectWithRef method the color of new pen object is {pen.Color}");
    }
}

public class Pen
{
    public string Color { get; set; }
    public Pen(string color)
    {
        Color = color;
    }
}

class Color
{
    public const string Red = "Red";
    public const string Green = "Green";
    public const string Blue = "Blue";
    public const string Yellow = "Yellow";
}

