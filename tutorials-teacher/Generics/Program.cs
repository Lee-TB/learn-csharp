namespace Generics
{
    internal class Program
    {        
        static void Main()
        {            
            Example1();
        }

        static void Example1()
        {
            DataStore<string> strStore = new DataStore<string>();
            strStore.Data = "Hello world!";
            Console.WriteLine(strStore.Data);
            //strStore.Data = 100; // compile-time error

            DataStore<int> intStore = new DataStore<int>();
            intStore.Data = 100;
            Console.WriteLine(intStore.Data);

            KeyValuePair<int, string> kvp1 = new KeyValuePair<int, string>();
            kvp1.Key = 1;
            kvp1.Value = "C#";
            Console.WriteLine(kvp1.Key + " " + kvp1.Value);

            KeyValuePair<string, string> kvp2 = new KeyValuePair<string, string>();
            kvp2.Key = "IT";
            kvp2.Value = "Information Technology";
            Console.WriteLine(kvp2.Key + " " + kvp2.Value);
        }
    }
}