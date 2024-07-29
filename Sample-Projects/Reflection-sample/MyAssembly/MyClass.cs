using MyMvc;

namespace MyAssembly;

[Controller]
public class MyClass
{
    public int myPublicInt = 10;
    private int myPrivateInt = 20;
    public static int myStaticInt = 30;

    public MyClass()
    {

    }

    public MyClass(int publicInt, int privateInt)
    {
        myPrivateInt = privateInt;
        myPublicInt = publicInt;
    }

    public void MyPublicMethod()
    {
        PrintValues();
    }

    private void PrintValues()
    {
        Console.WriteLine($"public: {myPublicInt} private: {myPrivateInt} static: {myStaticInt}");
    }

    private void MyPrivateMethod() {
        Console.WriteLine("private method invoked: Add result = "+ Add(myPrivateInt, myPublicInt));
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }
}
