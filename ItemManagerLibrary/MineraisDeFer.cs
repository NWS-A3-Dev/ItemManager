using System;
using System.Collections.Generic;
using System.Text;

namespace ItemManagerLibrary
{
    public class MineraisDeFer : Item, IMinerais
    {
        public override int GetPrice()
        {
            return (50);
        }
    }
}
