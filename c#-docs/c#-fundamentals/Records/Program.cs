namespace records
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //example1
            example1.Person person = new("Nancy", "Davolio");
            Console.WriteLine(person);

            //example2
            var phoneNumbers = new string[2];
            example2.Person person1 = new("Nancy", "Davolio", phoneNumbers);
            example2.Person person2 = new("Nancy", "Davolio", phoneNumbers);
            Console.WriteLine(person1 == person2); // output: True

            person1.PhoneNumbers[0] = "555-1234";
            Console.WriteLine(person1 == person2); // output: True

            Console.WriteLine(ReferenceEquals(person1, person2)); // output: False; because different instances

            //example3 object initializer
            example3.Person person3 = new() { FirstName = "Duc", LastName = "Tran"};

            //example4 `with` keyword
            example4.Person person4 = new("Nancy", "Davolio") { PhoneNumbers = new string[1] };
            Console.WriteLine(person4);
            // output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }

            example4.Person person5 = person4 with { FirstName = "John" };
            Console.WriteLine(person5); // output: Person { FirstName = John, LastName = Davolio, PhoneNumbers = System.String[] }
            Console.WriteLine(person5 == person4);

            person5 = person4 with {  PhoneNumbers = new string[1] };
            Console.WriteLine(person5); // output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }
            Console.WriteLine(person5 == person4);

            person5 = person4 with { };
            Console.WriteLine(person5); // output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }
            Console.WriteLine(person5 == person4);

        }


    }
}

namespace example1
{
    public record Person(string FirstName, string LastName);
}

namespace example2
{
    public record Person(string FirstName, string LastName, string[] PhoneNumbers);
}

namespace example3
{
    public record class Person
    {
        public required string FirstName { get; init; }
        public required string LastName { get; init; }
    };
}

namespace example4
{
    public record Person(string FirstName, string LastName) {
        public string[] PhoneNumbers { get; init; }
    }
}