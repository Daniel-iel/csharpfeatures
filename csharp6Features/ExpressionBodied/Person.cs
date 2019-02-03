using System;

namespace csharp6Features.ExpressionBodied
{
    public class Person
    {
        public string Name { get; }
        public string Surename { get; }

        public Person(string name, string surename)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surename))
            {
                throw new ArgumentException("Name and Surename is required");
            }

            this.Name = name;
            this.Surename = surename;
        }

        public override string ToString()
        => $"Full name {Name} {Surename}";
    }

}
