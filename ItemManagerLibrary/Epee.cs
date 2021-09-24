using System;
using System.Collections.Generic;
using System.Text;

namespace ItemManagerLibrary
{
    public class Epee : Item, IScrappable
    {
        public IEnumerable<Item> Scrap()
        {
            return (new Item[]
            {
                new MineraisDeFer(),
                new MineraisDeFer(),
                new MineraisDeFer(),
            });
        }

        public override int GetPrice()
        {
            return (200);
        }
    }
}
