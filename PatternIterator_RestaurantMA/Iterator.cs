using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIterator_RestaurantMA
{
    interface Iterator
    {
        bool hasNext();
        MenuItem Next();
    }

    class DinerMenuIterator : Iterator
    {
        private MenuItem[] items;
        int position = 0;

        public DinerMenuIterator(MenuItem[] items) => this.items = items;

        public bool hasNext() => (position < items.Length) & (items[position] != null);

        public MenuItem Next() => items[position++];
    }

    class PancakeHouseMenuIterator : Iterator
    {
        private List<MenuItem> items;
        int position = 0;

        public PancakeHouseMenuIterator(List<MenuItem> items) => this.items = items;

        public bool hasNext() => position < items.Count;

        public MenuItem Next() => items[position++];
    }
}
