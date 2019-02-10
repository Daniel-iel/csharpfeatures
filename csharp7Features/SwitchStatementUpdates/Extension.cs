using System;
using System.Collections.Generic;

namespace csharp7Features.SwitchStatementUpdates
{
    class Extension
    {
        public void SelectPerson()
        {
            List<object> objects = new List<object>()
            {
                new Person(){ },
                new List<Person>(){ },
                new Car(){},
                new List<Car>(){ },

            };

            foreach (var obj in objects)
            {
                switch (obj)
                {
                    case null:
                        continue;
                    case Car car:
                        Console.WriteLine("Car object");
                        break;
                    case List<Car> car:
                        Console.WriteLine("List Car object");
                        break;
                    default:
                        break;
                }                
            }
        }
    }

    class Person
    {

    }

    class Car
    {

    }
}
