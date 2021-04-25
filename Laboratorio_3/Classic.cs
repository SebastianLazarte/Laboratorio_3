using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_3
{
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
}
