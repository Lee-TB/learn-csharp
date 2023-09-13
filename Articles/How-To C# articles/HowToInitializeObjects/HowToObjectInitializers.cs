namespace HowToInitializeObjects;

public class HowToObjectInitializers
{
    public static void Run()
    {
        StudentName student1 = new StudentName("Craig", "Playstead");
        
        StudentName student2 = new StudentName
        {
            FirstName = "Duc",
            LastName = "Tran",
            ID = 1
        };
         
        StudentName student3 = new StudentName
        {
            ID = 183
        };

        // Declare a StudentName by using an object initializer and sending
        // arguments for all three properties. No corresponding constructor is
        // defined in the class.
        StudentName student4 = new StudentName
        {
            FirstName = "Craig",
            LastName = "Playstead",
            ID = 116
        };

        Console.WriteLine(student1.ToString());
        Console.WriteLine(student2.ToString());
        Console.WriteLine(student3.ToString());
        Console.WriteLine(student4.ToString());
    }

    public class StudentName
    {
        public StudentName() {
            Console.WriteLine("Parameterless constructor is called");
        }

        public StudentName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string? FirstName { get; set; }
        public string? LastName { get; set; } 
        public int ID { get; set; }

        public override string ToString()
        {
            return FirstName + " " + ID;
        }
    }
}
