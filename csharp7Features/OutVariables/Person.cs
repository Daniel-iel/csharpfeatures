using System;

namespace csharp7Features.OutVariables
{
    class Person
    {
        public void SetAge(string age)
        {
            if (int.TryParse(age, out int ageParse))
            {
                Console.WriteLine($"new age {ageParse}");
            }
        }
    }
}
