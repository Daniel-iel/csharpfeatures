using System;

namespace csharp6Features.TheNameOfExpression
{
    public class Car
    {
        public string Model { get; }
        public string Color { get; }

        public Car(string model, string color)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(model) || string.IsNullOrWhiteSpace(color))
                {
                    throw new ArgumentException("Model and color is required");
                }

                this.Model = model;
                this.Color = color;
            }
            catch (Exception)
            {

                throw new ArgumentException($"An exception occured in contrutor of {nameof(Car)} class");
            }

        }
    }
}
