namespace csharp6Features.UsingStatic
{
    using static MethodsHelper;

    public class Adress
    {
        public string Street { get; set; }
        public string PostCode { get; set; }

        public string GetCleanPostCode()
        {
            return RemoveSpace(this.PostCode);
        }
    }

    public static class MethodsHelper
    {
        public static string RemoveSpace(string value)
        {
            return value.Replace(" ", "");
        }
    }
}
