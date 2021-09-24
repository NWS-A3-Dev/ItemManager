using System;
using System.Collections.Generic;
using System.Text;

namespace ItemManagerLibrary
{
    public interface IScrappable
    {
        public IEnumerable<Item> Scrap();
    }
}
