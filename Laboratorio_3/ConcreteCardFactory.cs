using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_3
{
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
