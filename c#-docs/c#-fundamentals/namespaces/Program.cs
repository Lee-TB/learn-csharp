// First, .NET uses namespaces to organize its many classes
// Second, declaring your own namespaces can help you control the scope of class and method names in larger programming projects.
using SampleNamespace;

namespace namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // basic
            SampleNamespace.SampleClass sampleClassBasic = new SampleClass();

            // must using namespace at top 
            SampleClass sampleClass = new SampleClass();
            sampleClass.SampleMethod();

            AnotherSampleClass anotherSampleClass = new AnotherSampleClass();
            anotherSampleClass.AnotherSampleMethod();           
        }
    }
}

namespace SampleNamespace
{
    class SampleClass
    {
        public void SampleMethod()
        {
            System.Console.WriteLine("SampleMethod inside SampleNamespace");
        }
    }
}