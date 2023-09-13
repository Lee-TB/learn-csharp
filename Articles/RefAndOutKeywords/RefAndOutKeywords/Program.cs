namespace RefAndOutKeywords;

public class Program
{
    static void Main()
    {
        WithValueTypes.Run();

        Console.WriteLine("\n\nWith reference types");
        WithReferenceTypes.Run();
    }        
}