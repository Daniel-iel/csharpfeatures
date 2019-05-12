using System;

namespace csharp7._2FeaturesAssembly
{
    public class Class1
    {
        public void method()
        {
            var ferrari = new Ferrari();            
        }
    }

    public class Ferrari : Car
    {
        public int TopSpeed { get; set; }

        public void DoSomething()
        {
            Model = "spider";
        }
    }

    public abstract class Car
    {
        private protected string Model { get; set; }
    }
}
