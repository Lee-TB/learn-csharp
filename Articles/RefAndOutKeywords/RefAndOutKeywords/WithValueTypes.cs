namespace RefAndOutKeywords;
public class WithValueTypes
{
    public static void Run() {

        Console.WriteLine("Value types default behavior");
        int number = 2;
        Console.WriteLine($"Outside: {number}"); // Outside: 2
        ChangeNumber(number); // Inside: 3
        Console.WriteLine($"Outside: {number}"); // Outside: 2

        Console.WriteLine("\nRef keyword");
        int numberRef = 2;
        Console.WriteLine($"Outside: {numberRef}"); // Outside: 2
        ChangeNumberRef(ref numberRef); // Inside: 3
        Console.WriteLine($"Outside: {numberRef}"); // Outside: 3


        Console.WriteLine("\nOut keyword");
        int numberOut;
        Console.WriteLine("Unassigned number"); // Unassigned number
        ChangeNumberOut(out numberOut); // Inside: 3
        Console.WriteLine($"Outside: {numberOut}"); // Outside: 3
    }

    static void ChangeNumber(int number)
    {
        number = 3;
        Console.WriteLine($"Inside method: {number}");
    }

    static void ChangeNumberRef(ref int number)
    {
        number = 3;
        Console.WriteLine($"Inside method: {number}");
    }

    static void ChangeNumberOut(out int number)
    {
        number = 3;
        Console.WriteLine($"Inside method: {number}");
    }
}
