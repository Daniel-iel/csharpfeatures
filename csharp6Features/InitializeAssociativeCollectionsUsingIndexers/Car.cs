using System.Collections.Generic;

namespace csharp6Features.InitializeAssociativeCollectionsUsingIndexers
{
    public class Car
    {
        private readonly Dictionary<string, string> Cars = new Dictionary<string, string>
        {
            ["Honda"] = "HRV",
            ["Honda"] = "CRV",
            ["BMW"] = "320i",
        };
    }
}
