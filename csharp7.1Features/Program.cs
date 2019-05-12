using System;
using System.Threading.Tasks;

namespace csharp7._1Features
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //AsyncMain
            await new Dosomething().Do();

            //DefaultLiteralExpressions
            Func<string, bool> whereClause = default;

            //Inferred tuple element names
            int count = 8;
            string label = "some text";
            var pair = (count, label);
            Console.WriteLine($"count: {pair.count}, label: {pair.label}");

            Console.WriteLine("Hello World!");
        }
    }

    public class Dosomething
    {
        public async Task Do() { }
    }
}
