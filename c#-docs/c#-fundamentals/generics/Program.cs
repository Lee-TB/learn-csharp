using System.Runtime.InteropServices;

namespace generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Basic definition and usage
            GenericList<int> list1 = new GenericList<int>();
            list1.Add(1);
            //list1.Add("1"); // compile-time error

            GenericList<string> list2 = new GenericList<string>();
            //list2.Add(1); // compile-time error
            list2.Add("1");

            GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
            list3.Add(new ExampleClass());

            // using an 
            MyCollection.GenericList<int> list = new MyCollection.GenericList<int>();

            for(int i = 0; i<10; i++)
            {
                list.AddHead(i);
            }

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nDone");
        }
    }

    public class ExampleClass { }

    public class GenericList<T>
    {
        public void Add(T input) { }
    }
}

namespace MyCollection
{
    public class GenericList<T>
    {
        private class Node
        {
            public Node(T data)
            {
                _next = null;
                _data = data;
            }

            private Node? _next;
            public Node? Next
            {
                get { return _next; }
                set { _next = value; }
            }

            private T _data;
            public T Data
            {
                get { return _data; }
                set { _data = value; }
            }
        }

        private Node? _head;

        // constructor
        public GenericList()
        {
            _head = null;
        }

        public void AddHead(T data)
        {
            // create node
            Node node = new Node(data);
            node.Next = _head;

            _head = node;
        }
        public IEnumerator<T> GetEnumerator()
        {
            Node? current = _head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}