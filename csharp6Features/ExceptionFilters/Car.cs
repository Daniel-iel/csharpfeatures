using System;

namespace csharp6Features.ExceptionFilters
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
                    throw new ArgumentException("model is required");
                }

                if (string.IsNullOrWhiteSpace(color))
                {
                    throw new ArgumentException("color is required");
                }

                this.Model = model;
                this.Color = color;
            }
            catch (ArgumentException e) when (e.Message.Contains("model"))
            {
                this.Model = "NDA";
            }
            catch (ArgumentException e) when (e.Message.Contains("color"))
            {
                this.Color = "Black";
            }
        }
    }
}
