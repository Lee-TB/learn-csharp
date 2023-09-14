namespace Method_Overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Greet();

            Person p2 = new Employee();
            p2.Greet();

            Employee emp = new Employee();
            emp.Greet();

            Console.WriteLine();
            Display(p1);
            Display(emp);
        }

        static void Display(Person p)
        {
            p.Greet();
        }

        class Person
        {
            public virtual void Greet()
            {
                Console.WriteLine("Hi! I'm a person");
            }
        }

        class Employee : Person
        {

            public override void Greet()
            {
                Console.WriteLine("Hi! I'm a employee");
            }
        }
    }
}