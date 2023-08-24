using System.Runtime.CompilerServices;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WorkItem item = new WorkItem("Fix bugs", "Fix all bugs in my branch code", new TimeSpan(3, 4, 0, 0));
            ChangeRequest change = new ChangeRequest("Change Base Class Design",
                                        "Add members to the class",
                                        new TimeSpan(4, 0, 0), 1);
            Console.WriteLine(item);
            Console.WriteLine(change);
            change.Update("Change the Design of the Base Class", new TimeSpan(4, 0, 0));
            Console.WriteLine(change.ToString());
            
            Derived obj = new Derived();
            Base obj2 = new Base();
            var obj3 = ((Base)obj);
            obj2.DoWork(1);
            obj3.DoWork(2);
        }
    }
}

public class WorkItem
{
    // Static field currentID stores the job ID of the last WorkItem that has been created.
    private static int currentID;

    // Properties.
    protected int ID { get; set; }
    protected string Title { get; set; }
    protected string Description { get; set; }
    protected TimeSpan jobLength { get; set; }

    // The following method is called parameterless constructor OR default constuctor
    // 
    public WorkItem()
    {
        ID = 0;
        Title = "Default title";
        Description = "Default description";
        jobLength = new TimeSpan();
    }

    // Instace constructor that has three parameters.
    public WorkItem(string title, string description, TimeSpan jobLength)
    {
        this.ID = GetNextID();
        this.Title = title;
        this.Description = description;
        this.jobLength = jobLength;
    }

    protected int GetNextID()
    {
        return ++currentID;
    }

    public void Update(string Title, TimeSpan jobLength)
    {
        this.Title = Title;
        this.jobLength = jobLength;
    }

    public override string ToString() => $"{this.ID} - {this.Title}";
}

public class ChangeRequest : WorkItem
{
    protected int originalItemID { get; set; }

    // Default constructor for the derived class
    public ChangeRequest()
    {

    }

    // Instance constructor that has four parameters.
    public ChangeRequest(string title, string description, TimeSpan jobLength, int originalID)
    {
        // The following properties and the GetNextID method are inherited from WorkItem
        this.ID = GetNextID();
        this.Title = title;
        this.Description = description;
        this.jobLength = jobLength;
        // Proberty originalItemID is a member of ChangeRequest, but not of WorkItem.
        this.originalItemID = originalID;
    }
}

public class ParentClass
{
    public virtual void OverridableMethod()
    {
        Console.WriteLine("Parent behavior");
    }
}

public class ChildClass : ParentClass
{
    public override void OverridableMethod()
    {
        Console.WriteLine("Belong to Parent, Child type");
    }

    public void OnlyChildType()
    {
        Console.WriteLine("OnlyChildType callable");
    }
}

class Base
{
    public virtual void DoWork(int param) {
        Console.WriteLine("Base DoWork is called");
    }
}

class Derived : Base
{
    public override void DoWork(int param)
    {
        Console.WriteLine("Derived DoWork is called");
    }

    public void DoWork(double param) {
        Console.WriteLine("Double param Derived DoWork is called");
    }

}