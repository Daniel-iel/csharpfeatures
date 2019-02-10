using System;

namespace csharp7Features.MoreExpressionBodiedMembers
{
    class Car
    {
        public Car(string name) => this.Name = _name;

        ~Car() => Console.WriteLine("Finalized!");

        private string _name;
        public string Name
        {
            get => _name;
            set => this._name = value ?? "";
        }

    }
}
