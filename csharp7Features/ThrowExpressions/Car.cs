using System;

namespace csharp7Features.ThrowExpressions
{
    class Car
    {
        public Config config = LoadConfig() ?? throw new InvalidOperationException("Could not load config");

        public Car(string name) => this.Name = _name;
        ~Car() => Console.WriteLine("Finalized!");

        private string _name;
        public string Name
        {
            get => _name;
            set => this._name = value ?? "";
        }

        private static Config LoadConfig() => default(Config);

    }

    class Config { }
}
