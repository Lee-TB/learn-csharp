namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sw1 = new StopWatch();
            var sw2 = new StopWatch();
        }
    }
}

public class StopWatch
{
    // static constructor
    static StopWatch()
    {
        Console.WriteLine("Static constructor called");
    }

    // instance constructor
    public StopWatch()
    {
        Console.WriteLine("Instance constructor called");
    }

    // static method
    public static void DisplayInfo()
    {
        Console.WriteLine("DisplayInfo called");
    }

    // instance method
    public void Start() { }

    // instance method
    public void Stop() { }
}