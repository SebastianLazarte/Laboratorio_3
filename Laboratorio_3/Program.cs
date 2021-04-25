using System;

namespace Laboratorio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            CardFactory factory = new ConcreteCardFactory();

            ICard classic = factory.GetCard("Classic");
            classic.Credit(3000);
            Console.WriteLine("Deliver cash amount:"+classic.ExtraCash(500)+"$\n");

            ICard excellence = factory.GetCard("Excellence");
            excellence.Credit(5000);
            Console.WriteLine("Deliver cash amount:" + excellence.ExtraCash(600) + "$\n");

            ICard platinum = factory.GetCard("Platinum");
            platinum.Credit(2100);

        }
    }
}
