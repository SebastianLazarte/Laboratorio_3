using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_3
{
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
}
