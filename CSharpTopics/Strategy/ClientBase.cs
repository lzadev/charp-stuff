namespace Strategy
{
    public enum ClientType
    {
        DEFAULT,
        PREMIUM,
        REGULAR,
    }

    public abstract class ClientBase
    {
        public string Name { get; set; }
        public ClientType ClientType { get; set; }
        public double AmountBill { get; set; }
        public abstract double GetTotalAmount(IStrategy strategy);

        public ClientBase(string name, ClientType clientType, double total)
        {
            Name = name;
            ClientType = clientType;
            AmountBill = total;
        }
    }

    public class PremiumClient : ClientBase
    {
        public PremiumClient(string name, ClientType clientType, double total) : base(name, clientType, total)
        {

        }

        public override double GetTotalAmount(IStrategy strategy)
        {
            return strategy.GetDicount(this.AmountBill);
        }
    }

    public class RegularClient : ClientBase
    {
        public RegularClient(string name, ClientType clientType, double total) : base(name, clientType, total)
        {

        }

        public override double GetTotalAmount(IStrategy strategy)
        {
            return strategy.GetDicount(this.AmountBill);
        }
    }

    public interface IStrategy
    {
        double GetDicount(double amount);
    }

    public class PremiumClientStratery : IStrategy
    {
        public double GetDicount(double amount)
        {
            return amount - (amount * 0.50);
        }
    }

    public class RegularClientStratery : IStrategy
    {
        public double GetDicount(double amount)
        {
            return amount - (amount * 0.10);
        }
    }

    public class NoDiscountClientStratery : IStrategy
    {
        public double GetDicount(double amount)
        {
            return amount;
        }
    }
}