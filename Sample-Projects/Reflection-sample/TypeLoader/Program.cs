
using MyMvc;
using System.Reflection;

namespace TypeLoader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Usage: typeloader.exe <dll file name>");
            } else
            {
                var fileName = args[0];

                if(!File.Exists(fileName))
                {
                    Console.WriteLine("File not found");
                    return;
                }

                var asm = InspectAssembly(fileName);
                if (asm != null)
                {
                    LoadObjectFromAssembly(asm);
                }
            }
        }

        private static void LoadObjectFromAssembly(Assembly asm)
        {
            string typeName = "MyAssembly.MyClass";
            var type = asm.GetType(typeName);

            if (type != null)
            {
                var constructorInfo = type.GetConstructor([typeof(int), typeof(int)]);
                
                if( constructorInfo != null )
                {
                    var myObj = constructorInfo.Invoke([3, 5]);
                    if( myObj != null )
                    {
                        Console.WriteLine("Invove object methods---------------");
                        var method = type.GetMethod("MyPublicMethod");
                        method?.Invoke(myObj, []);
                        
                        
                        var customAttributes = method?.CustomAttributes;
                        var actionAttribute = customAttributes?.FirstOrDefault(a => a.AttributeType.IsAssignableTo(typeof(ActionAttribute)));
                        var actionName = method?.Name;
                        if(actionAttribute != null && actionAttribute.ConstructorArguments.Count > 0)
                        {
                            actionName = actionAttribute.ConstructorArguments[0].ToString();
                        }
                        Console.WriteLine($"action name: {actionName}");

                        method = type.GetMethod("MyPrivateMethod", BindingFlags.Instance | BindingFlags.NonPublic, []);
                        method?.Invoke(myObj, []);

                        method = type.GetMethod("Add", BindingFlags.Public | BindingFlags.Static,[typeof(int), typeof(int)]);
                        var result = method?.Invoke(myObj, [12, 3]);
                        Console.WriteLine($"add result = {result}");
                    }
                }
            } else
            {
                Console.WriteLine($"{typeName} not found");
            }

        }

        private static Assembly? InspectAssembly(string fileName)
        {
            var asm = Assembly.LoadFrom(fileName);
            if (asm != null)
            {
                PrintTypeInfo(asm);
            }
            return asm;
        }

        private static void PrintTypeInfo(Assembly asm)
        {            
            Console.WriteLine("Types----------------------");
            foreach (var type in asm.GetTypes())
            {
                Console.WriteLine(type.FullName);

                PrintMethodInfo(type);
                PrintFieldInfo(type);
            }            
        }

        private static void PrintFieldInfo(Type type)
        {
            Console.WriteLine("FieldInfo----------------------");
            foreach (var field in type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static))
            {
                Console.WriteLine($"{field.Name} {field.FieldType} {field.IsPrivate} {field.IsStatic}");
            }
        }

        private static void PrintMethodInfo(Type type)
        {
            Console.WriteLine("MethodInfo----------------------");
            foreach (var method in type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static))
            {
                if(method.DeclaringType == type)
                    Console.WriteLine(method.Name);
            }
        }
    }
}
