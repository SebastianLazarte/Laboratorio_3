using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_3
{
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
}
