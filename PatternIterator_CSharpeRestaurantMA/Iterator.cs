using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIterator_CSharpeRestaurantMA
{
    //interface Iterator
    //{
    //    bool hasNext();
    //    MenuItem Next();
    //}

    class DinerMenuIterator : IEnumerator<MenuItem>
    {
        //private MenuItem[] items;
        //int position = 0;

        //public DinerMenuIterator(MenuItem[] items) => this.items = items;

        //public bool hasNext() => (position < items.Length) & (items[position] != null);

        //public MenuItem Next() => items[position++];
        private MenuItem[] items;
        int position = 0;

        public DinerMenuIterator(MenuItem[] items) => this.items = items;

        public MenuItem Current => items[position];

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose() { }

        public bool MoveNext()
        {
            if ((position >= items.Length-1) | (items[position+1]==null))
                return false;
            position++;
            return true;
        }

        public void Reset()
        {
            position = 0;
        }
    }

    class PancakeHouseMenuIterator : IEnumerator<MenuItem>
    {
        //private List<MenuItem> items;
        //int position = 0;

        //public PancakeHouseMenuIterator(List<MenuItem> items) => this.items = items;

        //public bool hasNext() => position < items.Count;

        //public MenuItem Next() => items[position++];
        private List<MenuItem> items;
        int position = 0;

        public PancakeHouseMenuIterator(List<MenuItem> items) => this.items = items;

        public MenuItem Current => items[position];

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose() { }

        public bool MoveNext()
        {
            if (position >= items.Count-1)
                return false;
            position++;
            return true;
        }

        public void Reset()
        {
            position = 0;
        }
    }
}
