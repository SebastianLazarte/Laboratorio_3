using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_3
{
    public abstract class CardFactory
    {
        public abstract ICard GetCard(string CardType);

    }
}
