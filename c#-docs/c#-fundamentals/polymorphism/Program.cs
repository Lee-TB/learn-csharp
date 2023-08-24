namespace polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapeList = new List<Shape>
            {
                new Circle(),
                new Triangle(),
                new Rectangle(),
            };

            foreach (var shape in shapeList)
            {
                shape.Draw();
            }

            Console.WriteLine();
            BaseClass A = new BaseClass();
            A.DoWork();
            BaseClass B = new DerivedClass();
            B.DoWork();

            Console.WriteLine();
            BaseClass C = new DerivedClass();
            C.DoWork();
            DerivedClass D = new DerivedClass();
            D.DoWork();

            Console.WriteLine("\n\nHide base class members with new members");
            BaseHide a = new BaseHide();
            a.DoWork();
            BaseHide b = new DerivedHide(); ;
            b.DoWork();
        }
    }
}

public class A
{
    public virtual void DoWork() { }
}
public class B : A
{
    public sealed override void DoWork() { }
}

public class C : B
{
    //public override void DoWork() { } // Cannot override inherited member DoWork because it is sealed
}


public class Shape
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public virtual void Draw()
    {
        Console.WriteLine("Shape drawing..");
    }
}

public class Circle : Shape
{
    public override void Draw()
    {

    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        // Code to draw a rectangle...
        Console.WriteLine("Drawing a rectangle");
        base.Draw();
    }
}
public class Triangle : Shape
{
    public override void Draw()
    {
        // Code to draw a triangle...
        Console.WriteLine("Drawing a triangle");
        base.Draw();
    }
}

public class BaseClass
{
    public virtual void DoWork()
    {
        Console.WriteLine("base class do work");
    }
    public virtual int WorkProperty
    {
        get { return 0; }
    }
}
public class DerivedClass : BaseClass
{
    public override void DoWork()
    {
        Console.WriteLine("derived class do work");
    }
    public override int WorkProperty
    {
        get { return 0; }
    }
}

// Hide base class members with new members
public class BaseHide
{
    public void DoWork() { Console.WriteLine("BaseHide"); }

}

public class DerivedHide : BaseHide
{
    public new void DoWork() { Console.WriteLine("DerivedHide"); }
}
