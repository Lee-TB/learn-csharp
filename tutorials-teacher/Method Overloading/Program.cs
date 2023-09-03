namespace Method_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsolePrinter printer = new ConsolePrinter();
            printer.Print(1);
            printer.Print("Welcome");
            printer.Print("Hello", "C# here");
        }
    }

    partial class ConsolePrinter
    {
        public void Print(string str)
        {
            Console.WriteLine(str);
        }

        public void Print(string str1, string str2)
        {
            Console.WriteLine($"{str1}, {str2}");
        }

        public void Print(string str1, string str2, string str3)
        {
            Console.WriteLine($"{str1}, {str2}, {str3}");
        }
    }

    partial class ConsolePrinter
    {
        public void Print(int a)
        {
            Console.WriteLine(a);
        }

        public void Print(int a, int b)
        {
            Console.WriteLine($"Integer {a} {b}");
        }
    }
}