using System;
using System.Collections.Generic;

namespace csharp7Features.PatternMatching
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
                if (obj is Person per)
                {
                    Console.WriteLine("Person object");
                }
                else if (obj is List<Person> listPer)
                {
                    Console.WriteLine("List Person object");
                }
                else if (obj is Car car)
                {
                    Console.WriteLine("Car object");
                }
                else if (obj is List<Car> ListCar)
                {
                    Console.WriteLine("List Car object");
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
