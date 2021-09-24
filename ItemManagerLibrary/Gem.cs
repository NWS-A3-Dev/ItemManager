using System;
using System.Collections.Generic;
using System.Text;

namespace ItemManagerLibrary
{
    public abstract class Gem : Item
    {
    }

    public class Ruby : Gem
    {
        public override int GetPrice()
        {
            return (1000);
        }
    }

    public class Diamond : Gem
    {
        public override int GetPrice()
        {
            return (10000);
        }
    }
}
