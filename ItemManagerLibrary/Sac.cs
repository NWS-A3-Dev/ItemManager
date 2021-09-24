using System;
using System.Collections.Generic;
using System.Linq;

namespace ItemManagerLibrary
{
    public class Sac : List<Item>
    {
        public IEnumerable<IScrappable> GetScrappable()
        {
            IEnumerable<IScrappable> elements = this.OfType<IScrappable>().ToList();

            RemoveAll(i => i is IScrappable);

            return (elements);
        }

        public void DisplayContent()
        {
            IEnumerable<IGrouping<Type, Item>> items = this.GroupBy(i => i.GetType());

            foreach (IGrouping<Type, Item> item in items)
            {
                int amount = item.Count();
                int price = item.First().GetPrice() * amount;
                Console.WriteLine($"{item.Key.Name} x {amount} ({price} gold)");
            }
        }
    }
}
