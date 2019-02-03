namespace csharp6Features.NullConditionalOperators
{
    public class Car
    {
        private readonly string _color;

        public Car(Model model)
        {
            _color = model?.Color;
        }
    }

    public class Model
    {
        public string Color { get; set; }
    }
}
