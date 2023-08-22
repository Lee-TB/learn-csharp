class ClassWithFieldInitializer
{
    // When the .NET default isn't the right value, you can set an initial value using a field initializer:
    // Initialize capacity field to a default value of 10:
    private int _capacity = 10;
}

class ClassWithPrimaryConstructor(int capacity) // currently in preview version
{
    private int _capacity = capacity;
}

public class Container
{
    private int _capacity;

    public Container(int capacity) => _capacity = capacity;
}


public class Person
{
    public required string LastName { get; set; }
    public required string FirstName { get; set; }
}
