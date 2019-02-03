using System.Collections.Generic;

namespace csharp6Features.ExtensionAddMethodsInCollectionInitializers
{
    public class Car
    {
        private readonly ICollection<Car> cars = new List<Car>();

        public void AddListOfCars(List<Car> cars)
        {
            this.cars.Add(cars);
        }
    }

    public static class Extensions
    {
        public static void Add(this ICollection<Car> collection, List<Car> listOfCars)
        {
            foreach (var item in listOfCars)
            {
                collection.Add(item);
            }
        }
    }
}
