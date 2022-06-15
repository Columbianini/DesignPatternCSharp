using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternSingleton_ChocolateBolier
{
    class ChocolateBoiler
    {
        public bool empty { get; private set; }
        public bool boiled { get; private set; }

        private static ChocolateBoiler chocolateBoiler;

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler getInstance()
        {
            if (chocolateBoiler == null)
            {
                chocolateBoiler = new ChocolateBoiler();
            }
            return chocolateBoiler;
        }

        public void fill()
        {
            if (empty)
            {
                empty = false;
                boiled = false;
            }
        }

        public void drain()
        {
            if(!empty && boiled)
            {
                empty = true;
            }
        }

        public void boil()
        {
            if(!empty && !boiled)
            {
                boiled = true;
            }
        }
    }



    // Method 2: eagerly instantiation
    class ChocolateBoiler2
    {
        public bool empty { get; private set; }
        public bool boiled { get; private set; }

        private static ChocolateBoiler2 chocolateBoiler = new ChocolateBoiler2();

        private ChocolateBoiler2()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler2 getInstance()
        {
            return chocolateBoiler;
        }

        public void fill()
        {
            if (empty)
            {
                empty = false;
                boiled = false;
            }
        }

        public void drain()
        {
            if (!empty && boiled)
            {
                empty = true;
            }
        }

        public void boil()
        {
            if (!empty && !boiled)
            {
                boiled = true;
            }
        }
    }

}
