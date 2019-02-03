using System.Collections.Generic;

namespace csharp6Features.AutoPropertyInicializers
{
    public class Person
    {
        public ICollection<Person> Persons { get; } = new List<Person>();
    }
}
