// Subtypes must be substitutable for their base type.
using System.Collections;

namespace Liskov_Substitution_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            TestDrive(car);

            var truck = new Truck();
            TestDrive(truck);


            var aircraft = new Aircraft();
            TestDrive(aircraft); // side effect
        }

        public static void TestDrive(Vehicle vehicle)
        {
            vehicle.Drive();
        }
    }


    // Example 1
    public abstract class Vehicle
    {
        public abstract void Drive();
    }

    public class Car : Vehicle
    {
        public override void Drive() => Console.WriteLine("Drive a car");
    }

    public class Truck : Vehicle
    {
        public override void Drive() => Console.WriteLine("Drive a truck");
        
    }

    // because you can only fly an Aircraft, not drive it, the Drive() method in the Aircraft class raises an exception NotImplementedException
    public class Aircraft : Vehicle
    {
        public override void Drive() => throw new NotImplementedException();
    }


    // Example 2
    public interface IMyCollection
    {
        void Add(int item);
        void Remove(int item);
        int Get(int idex);
    }

    // As we can see MyReadOnlyCollection do not implement Add() and Remove() methods
    // To solve this problem we should create another interface for read-only collection without Add() and Remove() methods
    public class MyReadOnlyCollection : IMyCollection
    {
        private IList _collection;

        public MyReadOnlyCollection(IList<int> col)
        {
            _collection = (IList?)col;
        }
        public void Add(int item)
        {
            throw new NotImplementedException();
        }

        public int Get(int index)
        {
            return (int)_collection[index];
        }

        public void Remove(int item)
        {
            throw new NotImplementedException();
        }
    }

}