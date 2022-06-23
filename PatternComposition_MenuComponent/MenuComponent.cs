using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternComposition_MenuComponent
{
    abstract class MenuComponent
    {
        public virtual void add(MenuComponent menuComponent) => throw new NotSupportedException();
        public virtual void remove(MenuComponent menuComponent) => throw new NotSupportedException();
        public virtual MenuComponent getChild(int i) => throw new NotSupportedException();
        public virtual string Name { get { throw new NotSupportedException(); } }
        public virtual string Description { get { throw new NotSupportedException(); } }

        public virtual double Price { get { throw new NotSupportedException(); } }
        public virtual bool isVegetarian { get { throw new NotSupportedException(); } }

        public virtual void print() => throw new NotSupportedException();
    }


    class MenuItem : MenuComponent
    {
        private string _name;
        private string _description;
        private bool _isVegetarian;
        private double _price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            _name = name;
            _description = description;
            _isVegetarian = vegetarian;
            _price = price;
        }


        public override string Name => _name;
        public override string Description => _description;
        public override bool isVegetarian => _isVegetarian;
        public override double Price => _price;

        public override void print()
        {
            Console.WriteLine($" {Name}");
            if (isVegetarian)
                Console.WriteLine("(v)");
            Console.WriteLine($", {Price}");
            Console.WriteLine($" -- {Description}");
        }
    }

    class Menu: MenuComponent
    {
        List<MenuComponent> menuComponents = new List<MenuComponent>();
        private string _name;
        private string _description;

        public Menu(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public override void add(MenuComponent menuComponent) => menuComponents.Add(menuComponent);

        public override void remove(MenuComponent menuComponent) => menuComponents.Remove(menuComponent);

        public override MenuComponent getChild(int i) => menuComponents[i];

        public override string Name => _name;

        public override string Description => _description;

        public override void print()
        {
            Console.WriteLine($"\n{Name},{Description}");
            Console.WriteLine("-------------------------");

            foreach(var menuComponent in menuComponents)
            {
                menuComponent.print();
            }
        }


    }
}
