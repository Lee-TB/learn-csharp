void PrintArray(int[] items)
{
    string log = "";
    foreach (var item in items)
    {
        log += item.ToString() + ", ";
    }
    log = log.Substring(0, log.Length - 2);
    Console.WriteLine($"[{log}]");
}

int[] scores = { 3, 2, 5, 4, 1, 6 };

Console.WriteLine("Array Indeces");
Console.WriteLine($"scores[2] {scores[2]}");
Console.WriteLine($"scores[^2] {scores[^2]}");
Index index = 5;
Console.WriteLine($"scores[index] {scores[index]}");


// range returns a new array
Console.WriteLine("\nArray Ranges");
Console.Write("scores[2..] ");
PrintArray(scores[2..]);
Console.Write("scores[..2] ");
PrintArray(scores[..2]);
Console.Write("scores[2..5] ");
PrintArray(scores[2..5]);

Range range = 1..3;
Console.Write("Range range = 1..3; scores[range] ");
PrintArray(scores[range]);
