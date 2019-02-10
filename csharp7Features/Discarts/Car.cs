namespace csharp7Features.Discarts
{
    class Car
    {
        public (string, string) GetModelAndColor()
        {
            var (_, c) = GetModelAndColor1();

            return ("Honda", c);
        }

        public (string model, string color) GetModelAndColor1()
        {
            return (model: "Honda", color: "Black");
        }
    }
}
