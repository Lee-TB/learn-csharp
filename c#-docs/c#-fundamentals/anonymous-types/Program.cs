namespace anonymous_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var v = new { Amount = 100, Message = "hello" };
            Console.WriteLine(v);
            
            v = new { Amount = 108, Message = "hello world" };
            Console.WriteLine(v);

            Console.WriteLine(v.Amount + " " + v.Message);

            // It is also possible to define a field by object of another type: class, struct or even another anonymous type.
            var product = new Product();
            var bonus = new { note = "You won!" };
            var shipment = new { address = "Nowhere St.", product };
            var shipmentWithBonus = new { address = "Somewhere St.", product, bonus };

            // You can create an array of anonymous typed elements
            var anonArray = new[] { new { name = "apple", diam = 4 }, new { name = "graphe", diam = 1 } };
            foreach (var item in anonArray)
            {
                Console.WriteLine(item);
            }

            var apple = new { Item = "apples", Price = 1.35 };
            var onSale = apple with { Price = 1.35 * 0.9};
            Console.WriteLine(apple);
            Console.WriteLine(onSale);

            Console.WriteLine("\nAnonymous");
            var a = new { Item = "apples", Price = 1.35 };
            var b = new { Item = "apples", Price = 1.35 };
            Console.WriteLine(b.Equals(a)); // True
            Console.WriteLine(b == a); // Fasle
            Console.WriteLine(ReferenceEquals(a, b)); // False defferent instances


            Console.WriteLine("\nClass Student");
            Student s1 = new Student() { StudentId = "123", Name = "Test" };
            Student s2 = new Student() { StudentId = "123", Name = "Test" };           
            Console.WriteLine(s1.Equals(s2)); // False
            Console.WriteLine(s1 == s2); // Fasle
            Console.WriteLine(ReferenceEquals(s1, s2)); // False

            Console.WriteLine("\nRecord Student");
            RecordStudent rs1 = new RecordStudent() { StudentId = "123", Name="Test" };
            RecordStudent rs2 = new RecordStudent() { StudentId = "123", Name = "Test" };
            Console.WriteLine(rs1 == rs2); // True
            Console.WriteLine(rs1.Equals(rs2)); // True
            Console.WriteLine(ReferenceEquals(rs1, rs2)); // False            
        }
    }
}

class Product { }

class Student
{
    public string StudentId { get; set; }
    public string Name { get; set; }
}

record RecordStudent
{
    public string StudentId { get; set; }
    public string Name { get; set; }
}