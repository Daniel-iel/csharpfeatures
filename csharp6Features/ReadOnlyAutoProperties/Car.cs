using System;

namespace csharp6Features.ReadOnlyAutoProperties
{
    public class Car
    {
        public string Model { get; }
        public string Color { get; }

        public Car(string model, string color)
        {
            if (string.IsNullOrWhiteSpace(model) || string.IsNullOrWhiteSpace(color))
            {
                throw new ArgumentException("Model and color is required");
            }

            this.Model = model;
            this.Color = color;
        }      
    }
}
