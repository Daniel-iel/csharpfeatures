namespace csharp7Features.LocalFunctions
{
    class Person
    {
        public void GetAdress(TypeAdress typeAdress)
        {
            switch (typeAdress)
            {
                case TypeAdress.User:
                    var userAdress = BuildAdress();
                    userAdress.Active = false;
                    break;
                case TypeAdress.Order:
                    var oderAdress = BuildAdress();
                    oderAdress.Active = true;
                    break;
                default:
                    break;
            }

            Adress BuildAdress()
            {
                return new Adress() { };
            }
        }
    }

    class Adress
    {
        public bool Active { get; set; }
    }

    enum TypeAdress
    {
        User,
        Order
    }
}
