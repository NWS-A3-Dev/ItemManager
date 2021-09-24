using System;
using System.Collections.Generic;
using System.Linq;
using ItemManagerLibrary;

namespace ItemManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Sac sac = new Sac();

            sac.Add(new MineraisDeFer());
            sac.Add(new MineraisDeFer());
            sac.Add(new MineraisDeFer());

            sac.Add(new Epee());

            sac.Add(new Diamond());
            sac.Add(new Ruby());

            IEnumerable<Item> scrapped = sac.GetScrappable()
                .SelectMany(i => i.Scrap());

            sac.AddRange(scrapped);

            sac.DisplayContent();
        }
    }
}
