using System;

namespace Laboratorio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            CardFactory factory = new ConcreteCardFactory();

            ICard classic = factory.GetCard("Classic");
            classic.Credit(10);
            Console.WriteLine("Deliver cash amount:"+classic.ExtraCash(500)+"$");

            ICard excellence = factory.GetCard("Platinum");
            excellence.Credit(20);

        }
        
    }

    public interface ICard
    {
   
        void Credit(int amount);
        int ExtraCash(int amount);

    }
    public class Classic : ICard
    {
        public void Credit(int amount)
        {
            Console.WriteLine("Charge the Classic card :" + amount.ToString() + "$");
        }

        public int ExtraCash(int amount)
        {
            return amount;
        }
    }
    public class Platinum : ICard
    {
        public void Credit(int amount)
        {
            Console.WriteLine("Charge the Platinum card :" + amount.ToString() + "$");
        }

        public int ExtraCash(int amount)
        {
            return amount;
        }
    }
    public class Signature : ICard
    {
        public void Credit(int amount)
        {
            Console.WriteLine("Charge the Signature card : " + amount.ToString() + "bs");
        }

        public int ExtraCash(int amount)
        {
            return amount;
        }
    }
    public class Excellence : ICard
    {
        public void Credit(int amount)
        {
            Console.WriteLine("Charge the Excellence card : " + amount.ToString() + "bs");
        }

        public int ExtraCash(int amount)
        {
            return amount;
        }
    }
    public abstract class CardFactory
    {
        public abstract ICard GetCard(string CardType);

    }
    public class ConcreteCardFactory : CardFactory
    {
        public override ICard GetCard(string Card)
        {
            switch (Card)
            {
                case "Classic":
                    return new Classic();
                case "Platinum":
                    return new Platinum();
                case "Signature":
                    return new Signature();
                case "Excellence":
                    return new Excellence();
                default:
                    throw new Exception(string.Format("Card '{0}' cannot be created", Card));
            }
        }

    }
}
