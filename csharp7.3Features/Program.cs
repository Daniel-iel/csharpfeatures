using csharp7._2FeaturesAssembly;
using System;

namespace csharp7._2Features
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Safe efficient code enhancements
            var result = new DoSomething().Sum(15.15);

            //Conditional ref expressions
            int[] array = { 1, 1, 2, 3 };
            int[] array2 = { 4, 5 };

            ref var ar = ref (array != null ? ref array[0] : ref array2[0]);

            //private protected access modifier
            var lambo = new Lambo();

            //Non-trailing named arguments
            DoSomething("Adam", 18, "cooper");
            DoSomething(name: "Adam", age: 18, surname: "cooper");
            DoSomething(name: "Adam", 18, surname: "cooper");
            DoSomething("Adam", 18, surname: "cooper");
            DoSomething("Adam", surname: "cooper");
        }

        static void DoSomething(string name, int age = 10, string surname = "")
        {
        }
    }

    public class Lambo : Car
    {
        public void DoSomething()
        {
            //Model propertie does not show here, got to class 1 on csharp7._2FeaturesAssembly 
        }
    }

    internal class DoSomething
    {
        public double Sum(in double value) => value + value;
    }
}
