using System;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClientBase clientPremium = new RegularClient("Luis Zabala", ClientType.REGULAR, 200.0);
            var discount = clientPremium.GetTotalAmount(GetStrategy(clientPremium.ClientType));


            Console.WriteLine(discount);

            Console.ReadLine();
        }

        private static IStrategy GetStrategy(ClientType clientType)
        {
            switch (clientType)
            {
                case ClientType.DEFAULT:
                    return new NoDiscountClientStratery();
                case ClientType.PREMIUM:
                    return new PremiumClientStratery();
                case ClientType.REGULAR:
                    return new RegularClientStratery();
                default:
                    return new NoDiscountClientStratery();
            }
        }
    }
}
