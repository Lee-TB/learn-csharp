namespace classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person p1 = new Person(); // Error! Required properties not set
            Person p2 = new Person() { FirstName = "Duc", LastName = "Tran" };
            Person p3 = new Person { FirstName = "Duc", LastName = "Tran" };
            var p4 = new Person { FirstName = "Duc", LastName = "Tran" };
            Person p5 = new() { FirstName = "Duc", LastName = "Tran" };
        }
    }
}